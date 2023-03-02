using System.Text.Json;

namespace NishitBidOneDemo.Helpers;

public static class JsonHelper
{
    public static T? ReadFromFile<T>(string file)
    {
        return JsonSerializer.Deserialize<T>(File.ReadAllText(file));
    }

    public static string Serialize<T>(T data)
    {
        return JsonSerializer.Serialize(data);
    }

    public static void WriteToFile<T>(string file, T data)
    {
        File.WriteAllText(file, Serialize(data));
    }
}
