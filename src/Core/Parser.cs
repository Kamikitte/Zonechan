using System.Text;
using Newtonsoft.Json;
using Zonechan.Core.Models;

namespace Zonechan.Core;

public static class Parser
{
    private const string F95Url = "https://f95zone.to/sam/latest_alpha/latest_data.php?cmd=list&cat=games";

    public static async Task<Response?> GetResponse(
        int? page = null, 
        List<int>? tags = null, 
        List<int>? notags = null,
        List<int>? prefixes = null)
    {
        var stringbuilder = new StringBuilder();
        stringbuilder.Append(F95Url);
        using var client = new HttpClient();
        if (page != null)
        {
            stringbuilder.Append($"&page={page}");
        }

        if (tags is { Count: > 0 })
        {
            foreach (var tag in tags)
            {
                stringbuilder.Append($"&tags[]={tag}");
            }
        }

        if (notags is { Count: > 0 })
        {
            foreach (var notag in notags)
            {
                stringbuilder.Append($"&notags[]={notag}");
            }
        }

        if (prefixes is { Count: > 0 })
        {
            foreach (var prefix in prefixes)
            {
                stringbuilder.Append($"&prefixes[]={prefix}");
            }
        }

        var response = await client.GetAsync(stringbuilder.ToString());
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Response>(responseBody);
    }
}