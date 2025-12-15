namespace BikeRental.Models;

public class Renter
{
    ///
    /// Unique identifier for the renter.
    ///
    public required int Id { get; set; }

    ///
    /// Full name of the renter in the format "Last Name First Name Middle Name".
    ///
    public required string FullName { get; set; }

    ///
    /// Phone number of the renter.
    ///
    public required string PhoneNumber { get; set; }
}