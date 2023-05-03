using Newtonsoft.Json;

namespace EnquireSolutions.Sdk.Models;

public class IndividualRequest
{
    [JsonProperty(PropertyName = "individuals")]
    public Individual[] Individuals { get; set; } = default!;
}
public class Individual
{
    [JsonProperty(PropertyName = "properties")]
    public PropertyClass[] Properties { get; set; } = default!;

    [JsonProperty(PropertyName = "communities")]
    public Community[] Communities { get; set; } = default!;
}

public class PropertyClass
{
    [JsonProperty(PropertyName = "property")]
    public string Property { get; set; } = default!;

    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; } = default!;
}
