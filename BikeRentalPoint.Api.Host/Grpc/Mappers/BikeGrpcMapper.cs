using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// Маппер для преобразования gRPC-модели <see cref="BikeGrpc"/> в доменную сущность <see cref="Bike"/>.
/// </summary>
public static class BikeGrpcMapper
{
    /// <summary>
    /// Преобразует объект <see cref="BikeGrpc"/> в доменную сущность <see cref="Bike"/> для сохранения в базе данных.
    /// </summary>
    /// <param name="grpc">gRPC-модель велосипеда, полученная от сервиса генерации.</param>
    /// <returns>Заполненная доменная сущность <see cref="Bike"/>.</returns>
    public static Bike ToDomain(this BikeGrpc grpc) => new()
    {
        Id = Guid.Parse(grpc.Id),
        SerialNumber = grpc.SerialNumber,
        Color = string.IsNullOrWhiteSpace(grpc.Color) ? null : grpc.Color,
        ModelId = Guid.Parse(grpc.ModelId)
    };
}
