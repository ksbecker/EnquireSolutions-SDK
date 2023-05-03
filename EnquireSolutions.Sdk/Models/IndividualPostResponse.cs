using Newtonsoft.Json;

namespace EnquireSolutions.Sdk.Models;
public class IndividualPostResponse
{
    public string Message { get; set; } = default!;
    public IndividualPost[] Individuals { get; set; } = default!;
}

public class IndividualPost
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; } = default!;

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; } = default!;

    [JsonProperty(PropertyName = "community")]
    public string Community { get; set; } = default!;

    [JsonProperty(PropertyName = "type")]
    public int Type { get; set; }

    [JsonProperty(PropertyName = "isduplicate")]
    public bool IsDuplicate { get; set; }

    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; } = default!;

    [JsonProperty(PropertyName = "properties")]
    public Property1[] Properties { get; set; } = default!;
}

public class Property1
{
    public string Property { get; set; } = default!;
    public string Value { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string Message { get; set; } = default!;
}
