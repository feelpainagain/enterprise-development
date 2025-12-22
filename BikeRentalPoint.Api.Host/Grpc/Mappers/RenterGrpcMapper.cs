using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// Маппер для преобразования gRPC-модели <see cref="RenterGrpc"/> в доменную сущность <see cref="Renter"/>.
/// </summary>
public static class RenterGrpcMapper
{
    /// <summary>
    /// Преобразует объект <see cref="RenterGrpc"/> в доменную сущность <see cref="Renter"/> для сохранения в базе данных.
    /// </summary>
    /// <param name="grpc">gRPC-модель арендатора, полученная от сервиса генерации.</param>
    /// <returns>Заполненная доменная сущность <see cref="Renter"/>.</returns>
    public static Renter ToDomain(this RenterGrpc grpc) => new()
    {
        Id = Guid.Parse(grpc.Id),
        LastName = grpc.LastName,
        Name = grpc.Name,
        MiddleName = string.IsNullOrWhiteSpace(grpc.MiddleName) ? null : grpc.MiddleName,
        PhoneNumber = grpc.PhoneNumber
    };
}
