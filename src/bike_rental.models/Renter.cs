namespace Bike_rental.Models;

public class Renter
{
    /// <summary>
    /// Full name of the renter in the format "Last Name First Name Middle Name".
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Phone number of the renter.
    /// </summary>
    public required string PhoneNumber { get; set; }
}
