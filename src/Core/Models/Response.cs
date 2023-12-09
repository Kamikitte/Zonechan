using Newtonsoft.Json;

namespace Zonechan.Core.Models;

public sealed class Response
{
    public string Status { get; set; }

    [JsonProperty("msg")] 
    public Message Message { get; set; }
}