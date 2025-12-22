using Bogus;
using Grpc.Core;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Generation.GrpcServer.Services;

/// <summary>
/// Генерация BikeGrpc, RenterGrpc, RentGrpc и ModelGrpc для сервиса аренды велосипедов.
/// </summary>
public class GenerationServiceImpl(Faker faker) : GenerationService.GenerationServiceBase
{
    private static readonly List<string> _patronymics = new()
    {
        "Иванович", "Петрович", "Сергеевич", "Александрович",
        "Михайлович", "Романович", "Алексеевич", "Степанович",
        "Вячеславович", "Николаевич", "Александровна",
        "Сергеевна", "Михайловна"
    };

    private static readonly List<string> _colors = new()
    {
        "Red", "Blue", "Green", "Black", "White", "Yellow",
        "Orange", "Purple", "Gray", "Silver"
    };

    public override async Task Generate(
        IAsyncStreamReader<GenerationRequest> requestStream,
        IServerStreamWriter<GenerationResponse> responseStream,
        ServerCallContext context)
    {
        var totalCount = 0;
        var batchSize = 0;
        var currentBatch = 0;

        await foreach (var request in requestStream.ReadAllAsync(context.CancellationToken))
        {
            switch (request.PayloadCase)
            {
                case GenerationRequest.PayloadOneofCase.Start:
                    totalCount = request.Start.TotalCount;
                    batchSize = request.Start.BatchSize;
                    currentBatch = 0;

                    while (totalCount > 0 && !context.CancellationToken.IsCancellationRequested)
                    {
                        currentBatch++;
                        var thisBatchSize = Math.Min(batchSize, totalCount);

                        // Модели велосипедов
                        var models = Enumerable.Range(1, thisBatchSize)
                            .Select(_ => new ModelGrpc
                            {
                                Id = Guid.NewGuid().ToString(),
                                WheelSize = faker.Random.Double(20, 29),
                                MaxPassengerWeight = faker.Random.Double(70, 130),
                                BikeWeight = faker.Random.Double(8, 18),
                                BrakeType = faker.PickRandom<BrakeTypeGrpc>(),
                                ModelYear = faker.Date.Past(10).Year,
                                PricePerHour = Math.Round(faker.Random.Double(5, 20), 2),
                                BikeType = faker.PickRandom<BikeTypeGrpc>()
                            })
                            .ToList();

                        // Велосипеды
                        var bikes = Enumerable.Range(1, thisBatchSize)
                            .Select(i => new BikeGrpc
                            {
                                Id = Guid.NewGuid().ToString(),
                                SerialNumber = faker.Random.Replace("###-#####"),
                                Color = faker.PickRandom(_colors),
                                ModelId = models[i - 1].Id
                            })
                            .ToList();

                        // Арендаторы
                        var renters = Enumerable.Range(1, thisBatchSize)
                            .Select(_ => new RenterGrpc
                            {
                                Id = Guid.NewGuid().ToString(),
                                LastName = faker.Name.LastName(),
                                Name = faker.Name.FirstName(),
                                MiddleName = faker.PickRandom(_patronymics),
                                PhoneNumber = faker.Phone.PhoneNumber("###-###")
                            })
                            .ToList();

                        // Аренды
                        var rents = Enumerable.Range(1, thisBatchSize)
                            .Select(i => new RentGrpc
                            {
                                Id = Guid.NewGuid().ToString(),
                                StartTime = faker.Date.Recent().ToString("o"),
                                DurationMinutes = faker.Random.Int(30, 8 * 60),
                                BikeId = bikes[i - 1].Id,
                                RenterId = renters[i - 1].Id
                            })
                            .ToList();

                        var batchResponse = new GenerationResponse
                        {
                            Batch = new RentBatch
                            {
                                BatchNumber = currentBatch
                            }
                        };

                        batchResponse.Batch.Models.AddRange(models);
                        batchResponse.Batch.Bikes.AddRange(bikes);
                        batchResponse.Batch.Renters.AddRange(renters);
                        batchResponse.Batch.Rents.AddRange(rents);

                        await responseStream.WriteAsync(batchResponse, context.CancellationToken);

                        totalCount -= thisBatchSize;

                        if (!await WaitForAck(requestStream, context, currentBatch))
                            return;
                    }

                    await responseStream.WriteAsync(
                        new GenerationResponse
                        {
                            Completed = new GenerationCompleted { TotalBatches = currentBatch }
                        },
                        context.CancellationToken);

                    break;

                case GenerationRequest.PayloadOneofCase.Ack:
                    // Ack обрабатывается внутри WaitForAck
                    break;
            }
        }
    }

    /// <summary>
    /// Ожидание подтверждения обработки батча от клиента.
    /// </summary>
    private static async Task<bool> WaitForAck(
        IAsyncStreamReader<GenerationRequest> requestStream,
        ServerCallContext context,
        int currentBatch)
    {
        try
        {
            await foreach (var request in requestStream.ReadAllAsync(context.CancellationToken))
            {
                if (request.PayloadCase == GenerationRequest.PayloadOneofCase.Ack &&
                    request.Ack.BatchNumber == currentBatch)
                {
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }

        return false;
    }
}
