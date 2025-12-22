using BikeRentalPoint.Api.Host.Grpc.Mappers;
using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// Маппер для преобразования gRPC-модели <see cref="ModelGrpc"/> в доменную сущность <see cref="Model"/>.
/// </summary>
public static class ModelGrpcMapper
{
    /// <summary>
    /// Преобразует объект <see cref="ModelGrpc"/> в доменную сущность <see cref="Model"/> с учётом nullable-полей и маппинга enum-ов.
    /// </summary>
    /// <param name="grpc">gRPC-модель велосипедной модели, полученная от сервиса генерации.</param>
    /// <returns>Заполненная доменная сущность <see cref="Model"/>.</returns>
    public static Model ToDomain(this ModelGrpc grpc) => new()
    {
        Id = Guid.Parse(grpc.Id),
        WheelSize = grpc.WheelSize == 0 ? null : grpc.WheelSize,
        MaxPassengerWeight = grpc.MaxPassengerWeight == 0 ? null : grpc.MaxPassengerWeight,
        BikeWeight = grpc.BikeWeight == 0 ? null : grpc.BikeWeight,
        BrakeType = grpc.BrakeType.ToDomain(),
        ModelYear = grpc.ModelYear == 0 ? null : grpc.ModelYear,
        PricePerHour = (decimal)grpc.PricePerHour,
        BikeType = grpc.BikeType.ToDomain()
    };
}
