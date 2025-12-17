using BikeRentalPoint.Application.Contracts.Bike;
using BikeRentalPoint.Application.Contracts.Renter;

namespace BikeRentalPoint.Application.Contracts.Rent;

/// <summary>
/// Represents data for creating or updating a bicycle rental
/// </summary>
/// <param name="StartTime">Date and time when rental period starts</param>
/// <param name="Duration">Duration of the rental period</param>
/// <param name="Bike">Bicycle being rented</param>
/// <param name="Renter">Renter information</param>
public sealed record CreateRentDto(
    DateTime StartTime,
    TimeSpan Duration,
    BikeDto Bike,
    RenterDto Renter
);
