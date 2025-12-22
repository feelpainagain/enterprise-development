using BikeRentalPoint.Shared.Enums;
using BikeRentalPoint.Grpc.Contracts;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// Методы расширения для преобразования gRPC-перечислений в доменные enum-типы приложения.
/// </summary>
public static class EnumMappers
{
    /// <summary>
    /// Преобразует значение <see cref="BikeTypeGrpc"/> в доменный тип <see cref="BikeType"/>, подставляя значение по умолчанию при неопределённом варианте.
    /// </summary>
    /// <param name="grpcBikeType">gRPC-перечисление типа велосипеда, полученное от сервиса генерации.</param>
    /// <returns>Соответствующее значение доменного перечисления <see cref="BikeType"/>.</returns>
    public static BikeType ToDomain(this BikeTypeGrpc grpcBikeType) => grpcBikeType switch
    {
        BikeTypeGrpc.Road => BikeType.Road,
        BikeTypeGrpc.Mountain => BikeType.Mountain,
        BikeTypeGrpc.Hybrid => BikeType.Hybrid,
        BikeTypeGrpc.Electric => BikeType.Electric,
        BikeTypeGrpc.Folding => BikeType.Folding,
        BikeTypeGrpc.TwoSeat => BikeType.TwoSeat,
        _ => BikeType.Road
    };

    /// <summary>
    /// Преобразует значение <see cref="BrakeTypeGrpc"/> в доменный тип <see cref="BrakeType"/>, используя безопасное значение по умолчанию.
    /// </summary>
    /// <param name="grpcBrakeType">gRPC-перечисление типа тормозной системы, полученное от сервиса генерации.</param>
    /// <returns>Соответствующее значение доменного перечисления <see cref="BrakeType"/>.</returns>
    public static BrakeType ToDomain(this BrakeTypeGrpc grpcBrakeType) => grpcBrakeType switch
    {
        BrakeTypeGrpc.Rim => BrakeType.Rim,
        BrakeTypeGrpc.Disc => BrakeType.Disc,
        BrakeTypeGrpc.Drum => BrakeType.Drum,
        BrakeTypeGrpc.Tape => BrakeType.Tape,
        BrakeTypeGrpc.Spoon => BrakeType.Spoon,
        BrakeTypeGrpc.RodActuated => BrakeType.RodActuated,
        _ => BrakeType.Rim
    };
}
