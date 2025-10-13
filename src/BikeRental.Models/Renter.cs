namespace BikeRental.Models;

public class Renter
{
    /// <summary>
    /// Unique identifier for the renter.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Full name of the renter in the format "Last Name First Name Middle Name".
    /// </summary>
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// Phone number of the renter.
    /// </summary>
    public required string PhoneNumber { get; set; }
}