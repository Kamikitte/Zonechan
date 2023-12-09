namespace Zonechan.Core.Dictionaries;

public class Prefixes
{
    private static readonly Dictionary<int, string> prefixesDictionary = new()
    {
        { 23, "SiteRip" },
        { 19, "Collection" },
        { 13, "VN" },
        { 14, "Other engine" },
        { 5, "RAGS" },
        { 2, "RPGM" },
        { 47, "WebGL" },
        { 3, "Unity" },
        { 4, "HTML" },
        { 1, "QSP" },
        { 6, "Java" },
        { 7, "RenPy" },
        { 31, "Unreal Engine" },
        { 30, "Wolf RPG" },
        { 8, "Flash" },
        { 12, "Adrift" },
        { 17, "Tads" },
        { 18, "Completed" },
        { 20, "Onhold" },
        { 22, "Abandoned" },
    };

    public static string? GetPrefixById(int id) => prefixesDictionary.GetValueOrDefault(id);
}