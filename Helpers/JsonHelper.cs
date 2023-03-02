using System.Text.Json;

namespace NishitBidOneDemo.Helpers;

public static class JsonHelper
{
    static object _lock = new object();

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
        lock(_lock)
        {
            File.WriteAllText(file, Serialize(data));
        }
    }
}
