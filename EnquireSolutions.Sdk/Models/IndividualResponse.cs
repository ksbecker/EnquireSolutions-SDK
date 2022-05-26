using Newtonsoft.Json;

namespace EnquireSolutions.Sdk.Models;

public class IndividualResponse
{
    [JsonProperty(PropertyName = "result")]
    public Result Result { get; set; } = default!;
}

public class Result
{
    [JsonProperty(PropertyName = "total")]
    public string Total { get; set; } = default!;

    [JsonProperty(PropertyName = "individuals")]
    public Individuals Individuals { get; set; } = default!;
}

public class Individuals
{
    [JsonProperty(PropertyName = "individualid")]
    public string IndividualId { get; set; } = default!;

    [JsonProperty(PropertyName = "created")]
    public DateTime Created { get; set; }

    [JsonProperty(PropertyName = "createdby")]
    public string CreatedBy { get; set; } = default!;

    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; } = default!;

    [JsonProperty(PropertyName = "assignedUserId")]
    public string AssignedUserId { get; set; } = default!;

    [JsonProperty(PropertyName = "organizationId")]
    public string OrganizationId { get; set; } = default!;

    [JsonProperty(PropertyName = "communitycount")]
    public string? CommunityCount { get; set; }

    [JsonProperty(PropertyName = "community")]
    public Community[] Community { get; set; } = default!;

    [JsonProperty(PropertyName = "properties")]
    public IndividualProperty[] Properties { get; set; } = default!;
}

public class Community
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string NameUnique { get; set; } = default!;
}

public class IndividualProperty
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; } = default!;

    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; } = default!;

    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; } = default!;
}
