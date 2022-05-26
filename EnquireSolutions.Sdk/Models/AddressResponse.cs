namespace EnquireSolutions.Sdk.Models;

public class AddressResponse
{
    public int Id { get; set; }
    public int IndividualId { get; set; }
    public string IndividualName { get; set; } = default!;
    public string Type { get; set; } = default!;
    public string AddressLine1 { get; set; } = default!;
    public string AddressLine2 { get; set; } = default!;
    public string City { get; set; } = default!;
    public string County { get; set; } = default!;
    public string State { get; set; } = default!;
    public string StateCode { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public string Country { get; set; } = default!;
}
