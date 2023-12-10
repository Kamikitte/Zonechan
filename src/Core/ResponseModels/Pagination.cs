using Newtonsoft.Json;

namespace Zonechan.Core.ResponseModels;

public sealed class Pagination
{
    public Pagination(int page, int total)
    {
        Page = page;
        Total = total;
    }
    
    [JsonProperty("page")] 
    public int Page { get; set; }
    
    [JsonProperty("total")] 
    public int Total { get; set; }
}