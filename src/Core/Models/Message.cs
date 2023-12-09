namespace Zonechan.Core.Models;

public sealed class Message
{
    public List<Game> Data { get; set; }
    
    public Pagination Pagination { get; set; }
    
    public int Count { get; set; }
}