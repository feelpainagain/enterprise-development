using System;
using AutoMapper;
using BikeRentalPoint.Domain.Models;
using BikeRentalPoint.Grpc.Contracts;
using BikeRentalPoint.Shared.Enums;

namespace BikeRentalPoint.Api.Host.Grpc.Mappers;

/// <summary>
/// AutoMapper profile that defines mappings from gRPC contract models to domain entities.
/// </summary>
public class GrpcContractsToDomainProfile : Profile
{
    /// <summary>
    /// Initializes mapping rules between gRPC DTOs and domain entities used in the bike rental system.
    /// </summary>
    public GrpcContractsToDomainProfile()
    {
        CreateMap<BikeGrpc, Bike>()
            .AfterMap((src, dest) =>
            {
                dest.Id = Guid.Parse(src.Id);
                dest.SerialNumber = src.SerialNumber;
                dest.Color = string.IsNullOrWhiteSpace(src.Color) ? null : src.Color;
                dest.ModelId = Guid.Parse(src.ModelId);
            });

        CreateMap<RenterGrpc, Renter>()
            .AfterMap((src, dest) =>
            {
                dest.Id = Guid.Parse(src.Id);
                dest.LastName = src.LastName;
                dest.Name = src.Name;
                dest.MiddleName = string.IsNullOrWhiteSpace(src.MiddleName) ? null : src.MiddleName;
                dest.PhoneNumber = src.PhoneNumber;
            });

        CreateMap<RentGrpc, Rent>()
            .AfterMap((src, dest) =>
            {
                dest.Id = Guid.Parse(src.Id);
                dest.StartTime = DateTime.Parse(src.StartTime);
                dest.Duration = TimeSpan.FromMinutes(src.DurationMinutes);
                dest.BikeId = Guid.Parse(src.BikeId);
                dest.RenterId = Guid.Parse(src.RenterId);
            });

        CreateMap<ModelGrpc, Model>()
            .AfterMap((src, dest) =>
            {
                dest.Id = Guid.Parse(src.Id);

                dest.WheelSize = src.WheelSize == 0 ? null : src.WheelSize;
                dest.MaxPassengerWeight = src.MaxPassengerWeight == 0 ? null : src.MaxPassengerWeight;
                dest.BikeWeight = src.BikeWeight == 0 ? null : src.BikeWeight;

                dest.BrakeType = src.BrakeType switch
                {
                    BrakeTypeGrpc.Rim => BrakeType.Rim,
                    BrakeTypeGrpc.Disc => BrakeType.Disc,
                    BrakeTypeGrpc.Drum => BrakeType.Drum,
                    BrakeTypeGrpc.Tape => BrakeType.Tape,
                    BrakeTypeGrpc.Spoon => BrakeType.Spoon,
                    BrakeTypeGrpc.RodActuated => BrakeType.RodActuated,
                    _ => BrakeType.Rim
                };

                dest.ModelYear = src.ModelYear == 0 ? null : src.ModelYear;
                dest.PricePerHour = (decimal)src.PricePerHour;

                dest.BikeType = src.BikeType switch
                {
                    BikeTypeGrpc.Road => BikeType.Road,
                    BikeTypeGrpc.Mountain => BikeType.Mountain,
                    BikeTypeGrpc.Hybrid => BikeType.Hybrid,
                    BikeTypeGrpc.Electric => BikeType.Electric,
                    BikeTypeGrpc.Folding => BikeType.Folding,
                    BikeTypeGrpc.TwoSeat => BikeType.TwoSeat,
                    _ => BikeType.Road
                };
            });
    }
}
