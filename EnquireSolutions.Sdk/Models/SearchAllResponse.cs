namespace EnquireSolutions.Sdk.Models;

public class SearchAllResponse
{
    public int PortalId { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int Total { get; set; }
    public IndividualSearch[] Individuals { get; set; } = default!;
}

public class IndividualSearch
{
    public string CaseNumber { get; set; } = default!;
    public int IndividualId { get; set; }
    public DateTimeOffset DateUpdated { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public string Type { get; set; } = default!;
    public Community[] Community { get; set; } = default!;
    public Response[] Responses { get; set; } = default!;
}

public class Response
{
    public int Id { get; set; }
    public string Form { get; set; } = default!;
    public string Column { get; set; } = default!;
    public int ColumnId { get; set; }
    public string Value { get; set; } = default!;
}
