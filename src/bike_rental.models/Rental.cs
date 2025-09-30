namespace Bike_rental.Models;

public class RentalContract
{
    /// <summary>
    /// Unique identifier for the rental contract.
    /// </summary>
    public required int ContractId { get; set; }

    /// <summary>
    /// The full name of the renter.
    /// </summary>
    public required string RenterFullName { get; set; }

    /// <summary>
    /// The serial number of the bicycle being rented.
    /// </summary>
    public required string BicycleSerialNumber { get; set; }

    /// <summary>
    /// Start date and time of the rental.
    /// </summary>
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// Duration of the rental in hours.
    /// </summary>
    public required double RentalDurationHours { get; set; }
}
