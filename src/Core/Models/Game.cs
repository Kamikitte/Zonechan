using Newtonsoft.Json;

namespace Zonechan.Core.Models;

public sealed class Game
{
    [JsonProperty("thread_id")]
    public int Id { get; private set; }

    [JsonProperty("title")]
    public string Title { get; private set; }

    [JsonProperty("creator")]
    public string Creator { get; private set; }

    [JsonProperty("version")]
    public string Version { get; private set; }

    [JsonProperty("views")]
    public int Views { get; private set; }

    [JsonProperty("likes")]
    public int Likes { get; private set; }

    [JsonProperty("prefixes")]
    public List<int> Prefixes { get; private set; }

    [JsonProperty("tags")]
    public List<int> Tags { get; private set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("cover")]
    public string CoverUrl { get; set; }

    [JsonProperty("screens")]
    public List<string> ScreensUrls { get; set; }

    [JsonProperty("date")]
    public string WasPosted { get; set; }

    [JsonProperty("watched")]
    public bool IsWatched { get; set; }

    [JsonProperty("ignored")]
    public bool IsIgnored { get; set; }

    [JsonProperty("new")]
    public bool IsNew { get; set; }
}