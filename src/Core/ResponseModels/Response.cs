using Newtonsoft.Json;

namespace Zonechan.Core.ResponseModels;

public sealed class Response
{
    public Response(string status, Message message)
    {
        Status = status;
        Message = message;
    }
    
    [JsonProperty("status")] 
    public string Status { get; set; }

    [JsonProperty("msg")] 
    public Message Message { get; set; }
}