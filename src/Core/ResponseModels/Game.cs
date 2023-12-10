using Newtonsoft.Json;

namespace Zonechan.Core.ResponseModels;

public sealed class Game
{
    public Game(int id, string title, string creator, string version, int views, int likes, double rating,
        string coverUrl, string wasPosted, bool isWatched, bool isIgnored, bool isNew)
    {
        Id = id;
        Title = title;
        Creator = creator;
        Version = version;
        Views = views;
        Likes = likes;
        Rating = rating;
        CoverUrl = coverUrl;
        WasPosted = wasPosted;
        IsWatched = isWatched;
        IsIgnored = isIgnored;
        IsNew = isNew;
    }

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
    public IReadOnlyCollection<int> Prefixes { get; private set; } = new List<int>();

    [JsonProperty("tags")]
    public IReadOnlyCollection<int> Tags { get; private set; } = new List<int>();

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("cover")]
    public string CoverUrl { get; set; }

    [JsonProperty("screens")]
    public IReadOnlyCollection<string> ScreensUrls { get; set; } = new List<string>();

    [JsonProperty("date")]
    public string WasPosted { get; set; }

    [JsonProperty("watched")]
    public bool IsWatched { get; set; }

    [JsonProperty("ignored")]
    public bool IsIgnored { get; set; }

    [JsonProperty("new")]
    public bool IsNew { get; set; }
}