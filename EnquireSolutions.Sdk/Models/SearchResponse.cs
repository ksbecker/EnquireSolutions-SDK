namespace EnquireSolutions.Sdk;

public class SearchResponse
{
    public int Total { get; set; }
    public Case[] Cases { get; set; } = default!;
}

public class Case
{
    public Primary Primary { get; set; } = default!;
}

public class Primary
{
    public string CaseNumber { get; set; } = default!;
    public int IndividualId { get; set; }
    public string IndividualName { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public int IndividualTypeId { get; set; }
    public string IndividualType { get; set; } = default!;
    public bool PrimaryIndividual { get; set; }
    public bool IsPrimaryContact { get; set; }
    public string AssignedUser { get; set; } = default!;
    public int AssignedUserId { get; set; }
    public int IndividualStatusId { get; set; }
    public string IndividualStatusName { get; set; } = default!;
    public string RelationshipTypeSmart { get; set; } = default!;
    public DateTime DateCreated { get; set; }
    public string Email { get; set; } = default!;
    public string HomePhoneFormat { get; set; } = default!;
    public string AvatarFallback { get; set; } = default!;
    public string MobilePhoneFormat { get; set; } = default!;
    public string WorkPhoneFormat { get; set; } = default!;
    public Community[] Communities { get; set; } = default!;
    public int CommunityCount { get; set; }
    public string AddressLine1 { get; set; } = default!;
    public string AddressLine2 { get; set; } = default!;
    public string City { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public string StateCode { get; set; } = default!;
}

public class Community
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string NameUnique { get; set; } = default!;
    public string Abbreviation { get; set; } = default!;
    public string Color { get; set; } = default!;
    public int AddressId { get; set; }
    public bool CallCenter { get; set; }
}
