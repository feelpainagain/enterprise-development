using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using BikeRentalPoint.Domain;
using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;
using BikeRentalPoint.Api.Host.Grpc.Mappers;

namespace BikeRentalPoint.Api.Host.Grpc;

/// <summary>
/// Принимает данные, сгенерированные gRPC‑сервисом, и сохраняет их в БД через EF Core репозитории.
/// </summary>
public class GrpcClientConsumer
{
    private readonly IRepository<Model, Guid> _modelRepo;
    private readonly IRepository<Bike, Guid> _bikeRepo;
    private readonly IRepository<Renter, Guid> _renterRepo;
    private readonly IRepository<Rent, Guid> _rentRepo;
    private readonly GenerationService.GenerationServiceClient _grpcClient;

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="GrpcClientConsumer"/> с репозиториями доменных сущностей и gRPC‑клиентом генерации.
    /// </summary>
    public GrpcClientConsumer(
        IRepository<Model, Guid> modelRepo,
        IRepository<Bike, Guid> bikeRepo,
        IRepository<Renter, Guid> renterRepo,
        IRepository<Rent, Guid> rentRepo,
        GenerationService.GenerationServiceClient grpcClient)
    {
        _modelRepo = modelRepo;
        _bikeRepo = bikeRepo;
        _renterRepo = renterRepo;
        _rentRepo = rentRepo;
        _grpcClient = grpcClient;
    }

    /// <summary>
    /// Запускает генерацию тестовых данных на gRPC‑сервере и по мере получения батчей сохраняет модели, велосипеды, арендаторов и аренды в БД.
    /// </summary>
    /// <param name="totalCount">Общее количество записей каждого типа, которое требуется сгенерировать.</param>
    /// <param name="batchSize">Размер батча, то есть количество сущностей каждого типа в одном ответе.</param>
    /// <param name="cancellationToken">Токен отмены, позволяющий прервать операцию при необходимости.</param>
    public async Task StartGenerationAsync(int totalCount, int batchSize, CancellationToken cancellationToken = default)
    {
        using var call = _grpcClient.Generate();

        await call.RequestStream.WriteAsync(new GenerationRequest
        {
            Start = new StartGeneration
            {
                TotalCount = totalCount,
                BatchSize = batchSize
            }
        });

        await foreach (var response in call.ResponseStream.ReadAllAsync(cancellationToken))
        {
            switch (response.PayloadCase)
            {
                case GenerationResponse.PayloadOneofCase.Batch:
                    var batch = response.Batch;

                    foreach (var modelGrpc in batch.Models)
                    {
                        await _modelRepo.Create(modelGrpc.ToDomain());
                    }

                    foreach (var bikeGrpc in batch.Bikes)
                    {
                        await _bikeRepo.Create(bikeGrpc.ToDomain());
                    }

                    foreach (var renterGrpc in batch.Renters)
                    {
                        await _renterRepo.Create(renterGrpc.ToDomain());
                    }

                    foreach (var rentGrpc in batch.Rents)
                    {
                        await _rentRepo.Create(rentGrpc.ToDomain());
                    }

                    // отправляем ACK
                    await call.RequestStream.WriteAsync(new GenerationRequest
                    {
                        Ack = new BatchAck { BatchNumber = batch.BatchNumber }
                    });

                    break;

                case GenerationResponse.PayloadOneofCase.Completed:
                    Console.WriteLine($"Generation completed. Total batches: {response.Completed.TotalBatches}");
                    goto EndLoop;

                case GenerationResponse.PayloadOneofCase.Error:
                    Console.WriteLine($"Generation error: {response.Error.Message}");
                    goto EndLoop;
            }
        }

    EndLoop:
        await call.RequestStream.CompleteAsync();
    }
}
