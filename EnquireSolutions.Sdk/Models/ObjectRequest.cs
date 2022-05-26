namespace EnquireSolutions.Sdk.Models;

public class ObjectRequest
{
    public string Type { get; set; } = default!;
    public ESObject[] Object { get; set; } = default!;
}

public class ESObject
{
    public string Id { get; set; } = default!;

    public ObjectField[] Fields { get; set; } = default!;
}

public class ObjectField
{
    public int Id { get; set; }
    public string Value { get; set; } = default!;
    public string Label { get; set; } = default!;
}
