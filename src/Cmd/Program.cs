using Zonechan.Core;

namespace Zonechan.Cmd;

internal class Program
{
    private static async Task Main()
    {
        var response = await Parser.GetResponse(null, new List<int> { 75 });
        var test = 1;
    }
}