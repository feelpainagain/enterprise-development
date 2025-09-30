namespace Bike_rental.Models;

public class Bicycle
{
    /// <summary>
    /// Unique identifier for the bicycle, its serial number.
    /// </summary>
    public required string SerialNumber { get; set; }

    /// <summary>
    /// Model identifier linking to BikeModel.
    /// </summary>
    public required string ModelId { get; set; }

    /// <summary>
    /// Color of the bicycle.
    /// </summary>
    public required string Color { get; set; }
}