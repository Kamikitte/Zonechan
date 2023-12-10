using Newtonsoft.Json;

namespace Zonechan.Core.ResponseModels;

public sealed class Message
{
    public Message(Pagination pagination, int count)
    {
        Pagination = pagination;
        Count = count;
    }

    [JsonProperty("data")]
    public IReadOnlyCollection<Game> Games { get; set; } = new List<Game>();

    [JsonProperty("pagination")]
    public Pagination Pagination { get; set; }

    [JsonProperty("count")]
    public int Count { get; set; }
}