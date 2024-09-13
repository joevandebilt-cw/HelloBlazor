using System.Net.Http.Json;
using System.Text.Json;

namespace BethanysPieShop.HRM.Shared.Extensions;

public static class JsonExtensions
{
    public static string JsonSerialize<T>(this T obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    public static T? JsonDeserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
}
