using BikeRental.Models;

namespace BikeRental.Tests;

/// <summary>
/// Seeds test data to bike rental models.
/// </summary>
public class BikeRentalDataSeed
{
    /// <summary>
    /// List of seeded bicycle models.
    /// </summary>
    public List<BikeModel> BikeModels { get; } =
    [
        new BikeModel
        {
        Id = 1,
        Type = BikeType.Mountain,
        WheelSize = 27.5,
        MaxPassengerWeight = 120,
        BikeWeight = 14.5,
        BrakeType = "Disc",
        ModelYear = 2023,
        HourlyRentalPrice = 10.50m
        },
        new BikeModel
        {
        Id = 2,
        Type = BikeType.Road,
        WheelSize = 28.0,
        MaxPassengerWeight = 100,
        BikeWeight = 10.2,
        BrakeType = "Rim",
        ModelYear = 2022,
        HourlyRentalPrice = 12.00m
        },
        new BikeModel
        {
        Id = 3,
        Type = BikeType.Hybrid,
        WheelSize = 26.0,
        MaxPassengerWeight = 110,
        BikeWeight = 12.8,
        BrakeType = "Disc",
        ModelYear = 2024,
        HourlyRentalPrice = 9.75m
        },
        new BikeModel
        {
        Id = 4,
        Type = BikeType.Mountain,
        WheelSize = 29.0,
        MaxPassengerWeight = 130,
        BikeWeight = 15.0,
        BrakeType = "Disc",
        ModelYear = 2023,
        HourlyRentalPrice = 11.25m
        },
        new BikeModel
        {
        Id = 5,
        Type = BikeType.Road,
        WheelSize = 28.0,
        MaxPassengerWeight = 105,
        BikeWeight = 10.5,
        BrakeType = "Rim",
        ModelYear = 2021,
        HourlyRentalPrice = 13.00m
        },
        new BikeModel
        {
        Id = 6,
        Type = BikeType.Hybrid,
        WheelSize = 27.0,
        MaxPassengerWeight = 115,
        BikeWeight = 13.0,
        BrakeType = "Disc",
        ModelYear = 2024,
        HourlyRentalPrice = 10.00m
        },
        new BikeModel
        {
        Id = 7,
        Type = BikeType.Mountain,
        WheelSize = 27.5,
        MaxPassengerWeight = 125,
        BikeWeight = 14.8,
        BrakeType = "Disc",
        ModelYear = 2023,
        HourlyRentalPrice = 11.50m
        },
        new BikeModel
        {
        Id = 8,
        Type = BikeType.Road,
        WheelSize = 28.0,
        MaxPassengerWeight = 102,
        BikeWeight = 10.3,
        BrakeType = "Rim",
        ModelYear = 2022,
        HourlyRentalPrice = 12.50m
        },
        new BikeModel
        {
        Id = 9,
        Type = BikeType.Hybrid,
        WheelSize = 26.5,
        MaxPassengerWeight = 112,
        BikeWeight = 12.9,
        BrakeType = "Disc",
        ModelYear = 2024,
        HourlyRentalPrice = 9.90m
        },
        new BikeModel
        {
        Id = 10,
        Type = BikeType.Mountain,
        WheelSize = 29.0,
        MaxPassengerWeight = 135,
        BikeWeight = 15.2,
        BrakeType = "Disc",
        ModelYear = 2023,
        HourlyRentalPrice = 11.75m
        }
    ];

    /// <summary>
    /// List of seeded bicycles.
    /// </summary>
    public List<Bicycle> Bicycles { get; } =
    [
        new Bicycle
        {
        Id = 1,
        ModelId = 1,
        SerialNumber = "B001",
        Color = "Black"
        },
        new Bicycle
        {
        Id = 2,
        ModelId = 2,
        SerialNumber = "B002",
        Color = "Red"
        },
        new Bicycle
        {
        Id = 3,
        ModelId = 3,
        SerialNumber = "B003",
        Color = "Blue"
        },
        new Bicycle
        {
        Id = 4,
        ModelId = 4,
        SerialNumber = "B004",
        Color = "Green"
        },
        new Bicycle
        {
        Id = 5,
        ModelId = 5,
        SerialNumber = "B005",
        Color = "Yellow"
        },
        new Bicycle
        {
        Id = 6,
        ModelId = 6,
        SerialNumber = "B006",
        Color = "White"
        },
        new Bicycle
        {
        Id = 7,
        ModelId = 7,
        SerialNumber = "B007",
        Color = "Gray"
        },
        new Bicycle
        {
        Id = 8,
        ModelId = 8,
        SerialNumber = "B008",
        Color = "Orange"
        },
        new Bicycle
        {
        Id = 9,
        ModelId = 9,
        SerialNumber = "B009",
        Color = "Purple"
        },
        new Bicycle
        {
        Id = 10,
        ModelId = 10,
        SerialNumber = "B010",
        Color = "Silver"
        }
    ];

    /// <summary>
    /// List of seeded renters.
    /// </summary>
    public List<Renter> Renters { get; } =
    [
        new Renter
        {
        Id = 1,
        FullName = "Ivanov Ivan Ivanovich",
        PhoneNumber = "+79991234567"
        },
        new Renter
        {
        Id = 2,
        FullName = "Petrov Petr Petrovich",
        PhoneNumber = "+79992345678"
        },
        new Renter
        {
        Id = 3,
        FullName = "Sidorov Alexey Alexandrovich",
        PhoneNumber = "+79993456789"
        },
        new Renter
        {
        Id = 4,
        FullName = "Kuznetsov Dmitry Dmitrievich",
        PhoneNumber = "+79994567890"
        },
        new Renter
        {
        Id = 5,
        FullName = "Smirnov Sergey Sergeevich",
        PhoneNumber = "+79995678901"
        },
        new Renter
        {
        Id = 6,
        FullName = "Mikhailov Andrey Andreevich",
        PhoneNumber = "+79996789012"
        },
        new Renter
        {
        Id = 7,
        FullName = "Novikov Vladimir Vladimirovich",
        PhoneNumber = "+79997890123"
        },
        new Renter
        {
        Id = 8,
        FullName = "Fedorov Oleg Olegovich",
        PhoneNumber = "+79998901234"
        },
        new Renter
        {
        Id = 9,
        FullName = "Morozov Nikita Nikitovich",
        PhoneNumber = "+79999012345"
        },
        new Renter
        {
        Id = 10,
        FullName = "Volkov Igor Igorevich",
        PhoneNumber = "+79990123456"
        }
    ];

    /// <summary>
    /// List of seeded rental contracts.
    /// </summary>
    public List<RentalContract> RentalContracts { get; } =
    [
        new RentalContract
        {
        Id = 1,
        RenterId = 1,
        BicycleId = 1,
        StartTime = new DateTime(2025, 9, 30, 14, 30, 0),
        RentalDurationHours = 2.5
        },
        new RentalContract
        {
        Id = 2,
        RenterId = 2,
        BicycleId = 2,
        StartTime = new DateTime(2025, 9, 30, 15, 00, 0),
        RentalDurationHours = 1.0
        },
        new RentalContract
        {
        Id = 3,
        RenterId = 3,
        BicycleId = 3,
        StartTime = new DateTime(2025, 9, 30, 16, 15, 0),
        RentalDurationHours = 3.0
        },
        new RentalContract
        {
        Id = 4,
        RenterId = 4,
        BicycleId = 4,
        StartTime = new DateTime(2025, 9, 30, 17, 00, 0),
        RentalDurationHours = 2.0
        },
        new RentalContract
        {
        Id = 5,
        RenterId = 5,
        BicycleId = 5,
        StartTime = new DateTime(2025, 9, 30, 18, 30, 0),
        RentalDurationHours = 1.5
        },
        new RentalContract
        {
        Id = 6,
        RenterId = 6,
        BicycleId = 6,
        StartTime = new DateTime(2025, 9, 30, 19, 00, 0),
        RentalDurationHours = 2.0
        },
        new RentalContract
        {
        Id = 7,
        RenterId = 7,
        BicycleId = 7,
        StartTime = new DateTime(2025, 9, 30, 20, 15, 0),
        RentalDurationHours = 1.0
        },
        new RentalContract
        {
        Id = 8,
        RenterId = 8,
        BicycleId = 8,
        StartTime = new DateTime(2025, 9, 30, 21, 00, 0),
        RentalDurationHours = 2.5
        },
        new RentalContract
        {
        Id = 9,
        RenterId = 9,
        BicycleId = 9,
        StartTime = new DateTime(2025, 9, 30, 22, 30, 0),
        RentalDurationHours = 3.0
        },
        new RentalContract
        {
        Id = 10,
        RenterId = 10,
        BicycleId = 10,
        StartTime = new DateTime(2025, 9, 30, 23, 00, 0),
        RentalDurationHours = 1.5
        }
    ];
}