using Bogus;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Generation.GrpcServer.Services;

/// <summary>
/// Генерация BikeGrpc, RenterGrpc, RentGrpc и ModelGrpc для сервиса аренды велосипедов.
/// </summary>
public class GenerationServiceImpl : GenerationService.GenerationServiceBase
{
    private readonly Faker _faker;
    private readonly ILogger<GenerationServiceImpl> _logger;

    public GenerationServiceImpl(Faker faker, ILogger<GenerationServiceImpl> logger)
    {
        _faker = faker;
        _logger = logger;
    }

    private static readonly List<string> _patronymics =
    [
        "Иванович", "Петрович", "Сергеевич", "Александрович",
        "Михайлович", "Романович", "Алексеевич", "Степанович",
        "Вячеславович", "Николаевич", "Александровна",
        "Сергеевна", "Михайловна"
    ];

    private static readonly List<string> _colors =
    [
        "Red", "Blue", "Green", "Black", "White", "Yellow",
        "Orange", "Purple", "Gray", "Silver"
    ];

    /// <summary>
    /// Обрабатывает входящий поток запросов, читает Start и стримит батчи без ACK.
    /// </summary>
    public override async Task Generate(
        IAsyncStreamReader<GenerationRequest> requestStream,
        IServerStreamWriter<GenerationResponse> responseStream,
        ServerCallContext context)
    {
        var totalCount = 0;
        var batchSize = 0;
        var currentBatch = 0;

        _logger.LogInformation("Generation stream started");

        await foreach (var request in requestStream.ReadAllAsync(context.CancellationToken))
        {
            if (request.PayloadCase != GenerationRequest.PayloadOneofCase.Start)
                continue;

            totalCount = request.Start.TotalCount;
            batchSize = request.Start.BatchSize;
            currentBatch = 0;

            _logger.LogInformation(
                "Generation started: TotalCount = {TotalCount}, BatchSize = {BatchSize}",
                totalCount, batchSize);

            while (totalCount > 0 && !context.CancellationToken.IsCancellationRequested)
            {
                currentBatch++;
                var thisBatchSize = Math.Min(batchSize, totalCount);

                _logger.LogInformation(
                    "Generating batch {BatchNumber} with size {BatchSize}",
                    currentBatch, thisBatchSize);

                // Модели велосипедов
                var models = Enumerable.Range(1, thisBatchSize)
                    .Select(_ => new ModelGrpc
                    {
                        Id = Guid.NewGuid().ToString(),
                        WheelSize = _faker.Random.Double(20, 29),
                        MaxPassengerWeight = _faker.Random.Double(70, 130),
                        BikeWeight = _faker.Random.Double(8, 18),
                        BrakeType = _faker.PickRandom<BrakeTypeGrpc>(),
                        ModelYear = _faker.Date.Past(10).Year,
                        PricePerHour = Math.Round(_faker.Random.Double(5, 20), 2),
                        BikeType = _faker.PickRandom<BikeTypeGrpc>()
                    })
                    .ToList();

                // Велосипеды
                var bikes = Enumerable.Range(1, thisBatchSize)
                    .Select(i => new BikeGrpc
                    {
                        Id = Guid.NewGuid().ToString(),
                        SerialNumber = _faker.Random.Replace("###-#####"),
                        Color = _faker.PickRandom(_colors),
                        ModelId = models[i - 1].Id
                    })
                    .ToList();

                // Арендаторы
                var renters = Enumerable.Range(1, thisBatchSize)
                    .Select(_ => new RenterGrpc
                    {
                        Id = Guid.NewGuid().ToString(),
                        LastName = _faker.Name.LastName(),
                        Name = _faker.Name.FirstName(),
                        MiddleName = _faker.PickRandom(_patronymics),
                        PhoneNumber = _faker.Phone.PhoneNumber("###-###")
                    })
                    .ToList();

                // Аренды
                var rents = Enumerable.Range(1, thisBatchSize)
                    .Select(i => new RentGrpc
                    {
                        Id = Guid.NewGuid().ToString(),
                        StartTime = _faker.Date.Recent().ToString("o"),
                        DurationMinutes = _faker.Random.Int(30, 8 * 60),
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

                _logger.LogInformation(
                    "Batch {BatchNumber} sent to client", currentBatch);

                totalCount -= thisBatchSize;
            }

            await responseStream.WriteAsync(
                new GenerationResponse
                {
                    Completed = new GenerationCompleted { TotalBatches = currentBatch }
                },
                context.CancellationToken);

            _logger.LogInformation(
                "Generation completed. Total batches: {TotalBatches}",
                currentBatch);
        }

        _logger.LogInformation("Generation stream finished");
    }
}
