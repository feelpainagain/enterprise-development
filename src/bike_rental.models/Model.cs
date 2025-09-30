namespace Bike_rental.Models;

public class BikeModel
{
    /// <summary>
    /// Unique identifier for the bike model.
    /// </summary>
    public required string ModelId { get; set; }

    /// <summary>
    /// Type of the bicycle (e.g., mountain, road, hybrid).
    /// </summary>
    public required BikeType Type { get; set; }

    /// <summary>
    /// Wheel size of the bicycle in inches.
    /// </summary>
    public required double WheelSize { get; set; }

    /// <summary>
    /// Maximum allowable weight of the passenger in kilograms.
    /// </summary>
    public required double MaxPassengerWeight { get; set; }

    /// <summary>
    /// Weight of the bicycle in kilograms.
    /// </summary>
    public required double BikeWeight { get; set; }

    /// <summary>
    /// Type of brakes (e.g., disc, rim).
    /// </summary>
    public required string BrakeType { get; set; }

    /// <summary>
    /// Model year of the bicycle.
    /// </summary>
    public required int ModelYear { get; set; }

    /// <summary>
    /// Rental price per hour in the local currency.
    /// </summary>
    public required decimal HourlyRentalPrice { get; set; }
}