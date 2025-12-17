using BikeRentalPoint.Application.Contracts.Model;

namespace BikeRentalPoint.Application.Contracts.Bike;

/// <summary>
/// Interface for bicycle service operations
/// </summary>
public interface IBikeService : IApplicationService<BikeDto, CreateBikeDto, Guid>
{
}
