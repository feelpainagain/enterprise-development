using BikeRentalPoint.Application.Contracts.Bike;
using BikeRentalPoint.Application.Contracts.Renter;

namespace BikeRentalPoint.Application.Contracts.Rent;

/// <summary>
/// DTO for GET requests to rents
/// </summary>
/// <param name="Id">Unique identifier of the rental</param>
/// <param name="StartTime">Date and time when rental period started</param>
/// <param name="Duration">Duration of the rental period</param>
/// <param name="Bike">Rented bicycle details</param>
/// <param name="Renter">Renter details</param>
public sealed record RentDto(
    Guid Id,
    DateTime StartTime,
    TimeSpan Duration,
    BikeDto Bike,
    RenterDto Renter
);
