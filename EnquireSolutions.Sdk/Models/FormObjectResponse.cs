namespace EnquireSolutions.Sdk.Models;

public class FormObjectResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
    public FormField[] Fields { get; set; } = default!;
    public string[] Forms { get; set; } = default!;
}

public class FormField
{
    public int Id { get; set; }
    public string Form { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Label { get; set; } = default!;
    public string Type { get; set; } = default!;
    public bool Required { get; set; }
    public FormOption[] Options { get; set; } = default!;
    public int ColumnId { get; set; }
}

public class FormOption
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}

