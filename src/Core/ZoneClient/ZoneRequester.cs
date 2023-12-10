using System.Text;
using Newtonsoft.Json;
using Zonechan.Core.Exceptions;
using Zonechan.Core.InternalModels;
using Zonechan.Core.ResponseModels;

namespace Zonechan.Core.ZoneClient;

internal sealed class ZoneRequester : IZoneRequester
{
    private const string F95Url = "https://f95zone.to/sam/latest_alpha/latest_data.php?cmd=list&cat=games";

    public async Task<IReadOnlyCollection<Game>> GetGamesFromPageAsync(int page, Filter? filter)
    {
        var response = await GetResponseAsync(page, filter);
        return response.Message.Games;
    }

    private static async Task<Response> GetResponseAsync(int? page = default, Filter? filter = default)
    {
        using var client = new HttpClient();

        var response = await client.GetAsync(BuildRequest(page, filter));
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        
        return JsonConvert.DeserializeObject<Response>(responseBody) ?? 
               throw new DeserializationException($"Не удалось десериализовать сообщение: {responseBody}");
    }

    private static string BuildRequest(int? page, Filter? filter)
    {
        var stringbuilder = new StringBuilder();
        stringbuilder.Append(F95Url);
        
        if (page.HasValue)
        {
            stringbuilder.Append($"&page={page}");
        }

        if (filter is { Tags.Count: > 0 })
        {
            foreach (var tag in filter.Tags)
            {
                stringbuilder.Append($"&tags[]={Tags.GetTagIdByName(tag)}");
            }
        }

        if (filter is {IgnoredTags.Count: > 0})
        {
            foreach (var tag in filter.IgnoredTags)
            {
                stringbuilder.Append($"&notags[]={Tags.GetTagIdByName(tag)}");
            }
        }

        if (filter is {Prefixes.Count: > 0})
        {
            foreach (var prefix in filter.Prefixes)
            {
                stringbuilder.Append($"&prefixes[]={Prefixes.GetPrefixIdByName(prefix)}");
            }
        }

        return stringbuilder.ToString();
    }
}