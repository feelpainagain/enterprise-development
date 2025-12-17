using BikeRentalPoint.Application.Contracts.Bike;
using BikeRentalPoint.Application.Contracts.Renter;

namespace BikeRentalPoint.Application.Contracts.Rent;

/// <summary>
/// Interface for rental service operations
/// </summary>
public interface IRentService : IApplicationService<RentDto, CreateRentDto, Guid>
{
}
