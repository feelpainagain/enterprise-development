using Bike_rental.Models;

namespace Bike_rental.Tests;

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
        new BikeModel { ModelId = "M001", Type = BikeType.Mountain, WheelSize = 27.5, MaxPassengerWeight = 120, BikeWeight = 14.5, BrakeType = "Disc", ModelYear = 2023, HourlyRentalPrice = 10.50m },
        new BikeModel { ModelId = "M002", Type = BikeType.Road, WheelSize = 28.0, MaxPassengerWeight = 100, BikeWeight = 10.2, BrakeType = "Rim", ModelYear = 2022, HourlyRentalPrice = 12.00m },
        new BikeModel { ModelId = "M003", Type = BikeType.Hybrid, WheelSize = 26.0, MaxPassengerWeight = 110, BikeWeight = 12.8, BrakeType = "Disc", ModelYear = 2024, HourlyRentalPrice = 9.75m },
        new BikeModel { ModelId = "M004", Type = BikeType.Mountain, WheelSize = 29.0, MaxPassengerWeight = 130, BikeWeight = 15.0, BrakeType = "Disc", ModelYear = 2023, HourlyRentalPrice = 11.25m },
        new BikeModel { ModelId = "M005", Type = BikeType.Road, WheelSize = 28.0, MaxPassengerWeight = 105, BikeWeight = 10.5, BrakeType = "Rim", ModelYear = 2021, HourlyRentalPrice = 13.00m },
        new BikeModel { ModelId = "M006", Type = BikeType.Hybrid, WheelSize = 27.0, MaxPassengerWeight = 115, BikeWeight = 13.0, BrakeType = "Disc", ModelYear = 2024, HourlyRentalPrice = 10.00m },
        new BikeModel { ModelId = "M007", Type = BikeType.Mountain, WheelSize = 27.5, MaxPassengerWeight = 125, BikeWeight = 14.8, BrakeType = "Disc", ModelYear = 2023, HourlyRentalPrice = 11.50m },
        new BikeModel { ModelId = "M008", Type = BikeType.Road, WheelSize = 28.0, MaxPassengerWeight = 102, BikeWeight = 10.3, BrakeType = "Rim", ModelYear = 2022, HourlyRentalPrice = 12.50m },
        new BikeModel { ModelId = "M009", Type = BikeType.Hybrid, WheelSize = 26.5, MaxPassengerWeight = 112, BikeWeight = 12.9, BrakeType = "Disc", ModelYear = 2024, HourlyRentalPrice = 9.90m },
        new BikeModel { ModelId = "M010", Type = BikeType.Mountain, WheelSize = 29.0, MaxPassengerWeight = 135, BikeWeight = 15.2, BrakeType = "Disc", ModelYear = 2023, HourlyRentalPrice = 11.75m }
    ];

    /// <summary>
    /// List of seeded bicycles.
    /// </summary>
    public List<Bicycle> Bicycles { get; } =
    [
        new Bicycle { SerialNumber = "B001", ModelId = "M001", Color = "Black" },
        new Bicycle { SerialNumber = "B002", ModelId = "M002", Color = "Red" },
        new Bicycle { SerialNumber = "B003", ModelId = "M003", Color = "Blue" },
        new Bicycle { SerialNumber = "B004", ModelId = "M004", Color = "Green" },
        new Bicycle { SerialNumber = "B005", ModelId = "M005", Color = "Yellow" },
        new Bicycle { SerialNumber = "B006", ModelId = "M006", Color = "White" },
        new Bicycle { SerialNumber = "B007", ModelId = "M007", Color = "Gray" },
        new Bicycle { SerialNumber = "B008", ModelId = "M008", Color = "Orange" },
        new Bicycle { SerialNumber = "B009", ModelId = "M009", Color = "Purple" },
        new Bicycle { SerialNumber = "B010", ModelId = "M010", Color = "Silver" }
    ];

    /// <summary>
    /// List of seeded renters.
    /// </summary>
    public List<Renter> Renters { get; } =
    [
        new Renter { FullName = "Ivanov Ivan Ivanovich", PhoneNumber = "+79991234567" },
        new Renter { FullName = "Petrov Petr Petrovich", PhoneNumber = "+79992345678" },
        new Renter { FullName = "Sidorov Alexey Alexandrovich", PhoneNumber = "+79993456789" },
        new Renter { FullName = "Kuznetsov Dmitry Dmitrievich", PhoneNumber = "+79994567890" },
        new Renter { FullName = "Smirnov Sergey Sergeevich", PhoneNumber = "+79995678901" },
        new Renter { FullName = "Mikhailov Andrey Andreevich", PhoneNumber = "+79996789012" },
        new Renter { FullName = "Novikov Vladimir Vladimirovich", PhoneNumber = "+79997890123" },
        new Renter { FullName = "Fedorov Oleg Olegovich", PhoneNumber = "+79998901234" },
        new Renter { FullName = "Morozov Nikita Nikitovich", PhoneNumber = "+79999012345" },
        new Renter { FullName = "Volkov Igor Igorevich", PhoneNumber = "+79990123456" }
    ];

    /// <summary>
    /// List of seeded rental contracts.
    /// </summary>
    public List<RentalContract> RentalContracts { get; } =
    [
        new RentalContract { ContractId = 1, RenterFullName = "Ivanov Ivan Ivanovich", BicycleSerialNumber = "B001", StartTime = new DateTime(2025, 9, 30, 14, 30, 0), RentalDurationHours = 2.5 },
        new RentalContract { ContractId = 2, RenterFullName = "Petrov Petr Petrovich", BicycleSerialNumber = "B002", StartTime = new DateTime(2025, 9, 30, 15, 00, 0), RentalDurationHours = 1.0 },
        new RentalContract { ContractId = 3, RenterFullName = "Sidorov Alexey Alexandrovich", BicycleSerialNumber = "B003", StartTime = new DateTime(2025, 9, 30, 16, 15, 0), RentalDurationHours = 3.0 },
        new RentalContract { ContractId = 4, RenterFullName = "Kuznetsov Dmitry Dmitrievich", BicycleSerialNumber = "B004", StartTime = new DateTime(2025, 9, 30, 17, 00, 0), RentalDurationHours = 2.0 },
        new RentalContract { ContractId = 5, RenterFullName = "Smirnov Sergey Sergeevich", BicycleSerialNumber = "B005", StartTime = new DateTime(2025, 9, 30, 18, 30, 0), RentalDurationHours = 1.5 },
        new RentalContract { ContractId = 6, RenterFullName = "Mikhailov Andrey Andreevich", BicycleSerialNumber = "B006", StartTime = new DateTime(2025, 9, 30, 19, 00, 0), RentalDurationHours = 2.0 },
        new RentalContract { ContractId = 7, RenterFullName = "Novikov Vladimir Vladimirovich", BicycleSerialNumber = "B007", StartTime = new DateTime(2025, 9, 30, 20, 15, 0), RentalDurationHours = 1.0 },
        new RentalContract { ContractId = 8, RenterFullName = "Fedorov Oleg Olegovich", BicycleSerialNumber = "B008", StartTime = new DateTime(2025, 9, 30, 21, 00, 0), RentalDurationHours = 2.5 },
        new RentalContract { ContractId = 9, RenterFullName = "Morozov Nikita Nikitovich", BicycleSerialNumber = "B009", StartTime = new DateTime(2025, 9, 30, 22, 30, 0), RentalDurationHours = 3.0 },
        new RentalContract { ContractId = 10, RenterFullName = "Volkov Igor Igorevich", BicycleSerialNumber = "B010", StartTime = new DateTime(2025, 9, 30, 23, 00, 0), RentalDurationHours = 1.5 }
    ];
}