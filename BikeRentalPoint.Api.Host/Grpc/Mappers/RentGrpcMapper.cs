using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// Маппер для преобразования gRPC-модели <see cref="RentGrpc"/> в доменную сущность <see cref="Rent"/>.
/// </summary>
public static class RentGrpcMapper
{
    /// <summary>
    /// Преобразует объект <see cref="RentGrpc"/> в доменную сущность <see cref="Rent"/> с конвертацией даты начала и длительности аренды.
    /// </summary>
    /// <param name="grpc">gRPC-модель аренды, полученная от сервиса генерации.</param>
    /// <returns>Заполненная доменная сущность <see cref="Rent"/>.</returns>
    public static Rent ToDomain(this RentGrpc grpc) => new()
    {
        Id = Guid.Parse(grpc.Id),
        StartTime = DateTime.Parse(grpc.StartTime),
        Duration = TimeSpan.FromMinutes(grpc.DurationMinutes),
        BikeId = Guid.Parse(grpc.BikeId),
        RenterId = Guid.Parse(grpc.RenterId)
    };
}
