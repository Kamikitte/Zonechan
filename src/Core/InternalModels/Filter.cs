namespace Zonechan.Core.InternalModels;

public sealed class Filter
{
    public IReadOnlyCollection<string> Tags { get; set; } = new List<string>();

    public IReadOnlyCollection<string> IgnoredTags { get; set; } = new List<string>();

    public IReadOnlyCollection<string> Prefixes { get; set; } = new List<string>();
}