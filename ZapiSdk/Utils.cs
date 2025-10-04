using System.Text.Json;
using ZApi.Models;

namespace ZApi;
internal static class Utils
{
    internal static async Task<ZapiResponse> ProcessError(HttpResponseMessage response)
    {
        var result = new ZapiResponse
        {
            Success = false,
            Errors = new List<string>()
        };

        var contentStr = await response.Content.ReadAsStringAsync();
        using var jsonDoc = JsonDocument.Parse(contentStr);

        if (jsonDoc.RootElement.TryGetProperty("error", out var error))
        {
            var errorMessage = error.GetString();

            if (errorMessage != null) 
                result.Errors.Add(errorMessage);

            return result;
        }

        throw new Exception("Unknown Error");
    }
}
