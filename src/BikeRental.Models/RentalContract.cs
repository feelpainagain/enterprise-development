namespace BikeRental.Models;

public class RentalContract
{
    /// <summary>
    /// Unique identifier for the rental contract.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The unique identifier of the renter.
    /// </summary>
    public required int RenterId { get; set; }

    /// <summary>
    /// The unique identifier of the bicycle being rented.
    /// </summary>
    public required int BicycleId { get; set; }

    /// <summary>
    /// Start date and time of the rental.
    /// </summary>
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// Duration of the rental in hours.
    /// </summary>
    public required double RentalDurationHours { get; set; }
}