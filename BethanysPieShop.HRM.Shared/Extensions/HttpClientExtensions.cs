namespace BethanysPieShop.HRM.Shared.Extensions;

public static class HttpClientExtensions
{
    public static void SetBody<T>(this HttpRequestMessage request, T obj)
    {
        request.Content = new StringContent(obj.JsonSerialize());
    }

    public static async Task<T?> SendAndProcess<T>(this HttpClient client, HttpRequestMessage requestMessage)
    {
        var response = await client.SendAsync(requestMessage);
        if (response.IsSuccessStatusCode)
        {
            string body = await response.Content.ReadAsStringAsync();
            var result = JsonExtensions.JsonDeserialize<T>(body);
            return result;
        }
        return default;
    }

    public static async Task<T?> MakeWebRequest<T>(this HttpClient client, HttpMethod method, string url)
    {
        var request = new HttpRequestMessage(method, url);
        return await client.SendAndProcess<T>(request);
    }

    public static async Task<T?> MakeWebRequest<T>(this HttpClient client, HttpMethod method, string url, T content)
    {
        return await client.MakeWebRequest<T, T>(method, url, content);
    }

    public static async Task<TOut?> MakeWebRequest<TOut, TIn>(this HttpClient client, HttpMethod method, string url, TIn content)
    {
        var request = new HttpRequestMessage(method, url);
        request.SetBody(content);
        return await client.SendAndProcess<TOut>(request);
    }
}
