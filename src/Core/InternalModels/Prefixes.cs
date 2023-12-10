namespace Zonechan.Core.InternalModels;

public static class Prefixes
{
    private static readonly IReadOnlyDictionary<string, int> prefixesDictionary = new Dictionary<string, int>()
    {
        { "QSP", 1 },
        { "RPGM", 2 }, 
        { "Unity", 3 },
        { "HTML", 4 }, 
        { "RAGS", 5 }, 
        { "Java", 6 },
        { "RenPy", 7 },
        { "Flash", 8 },
        { "Adrift", 12 },
        { "VN", 13 },
        { "Other engine", 14 },
        { "Tads", 17 },
        { "Completed", 18 },
        { "Collection", 19 },
        { "Onhold", 20 },
        { "Abandoned", 22 },
        { "SiteRip", 23 },
        { "Wolf RPG", 30 },
        { "Unreal Engine", 31 },
        { "WebGL", 47 },
    };

    public static int? GetPrefixIdByName(string prefixName) => prefixesDictionary.GetValueOrDefault(prefixName);
}