namespace BikeRental.Models;

public class Bicycle
{
    /// <summary>
    /// Unique identifier for the bicycle.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Model identifier linking to BikeModel.
    /// </summary>
    public required int ModelId { get; set; }

    /// <summary>
    /// Color of the bicycle.
    /// </summary>
    public required string Color { get; set; }

    /// <summary>
    /// Serial number of the bicycle (optional, for reference).
    /// </summary>
    public string SerialNumber { get; set; }
}