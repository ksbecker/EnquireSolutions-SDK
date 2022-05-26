using Newtonsoft.Json;

namespace EnquireSolutions.Sdk.Models;

public class ObjectPutResponse
{
    public int Id { get; set; }

    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; } = default!;

    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; } = default!;
}
