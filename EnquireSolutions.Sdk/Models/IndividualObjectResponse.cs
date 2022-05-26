namespace EnquireSolutions.Sdk.Models;

public class IndividualObjectResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
    public IndividualObjectField[] Fields { get; set; } = default!;
    public string[] Forms { get; set; } = default!;
}

public class IndividualObjectField
{
    public int Id { get; set; }
    public string Form { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Label { get; set; } = default!;
    public string Type { get; set; } = default!;
    public bool Required { get; set; }
    public IndividualObjectOption[]? Options { get; set; }
    public int ColumnId { get; set; }
}

public class IndividualObjectOption
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}
