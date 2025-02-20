using System.Net.Http.Json;
using System.Text.Json;
using ZapiSdk.Contracts;
using ZapiSdk.Models;

namespace ZapiSdk
{
    internal class Instance : IInstance
    {
        readonly HttpClient _http;

        public Instance(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<byte[]> GetQrCodeBytes()
        {
            using var response = await _http.GetAsync("qr-code");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<string> GetQrCodeImage()
        {
            using var response = await _http.GetAsync("qr-code/image");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPhoneCode(string phone)
        {
            using var response = await _http.GetAsync($"phone-code/{phone}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<InstanceStatusResponse> GetStatus()
        {
            using var response = await _http.GetAsync("status");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<InstanceStatusResponse>()
                ?? throw new Exception("Failed to deserialize the response content to InstanceStatusResponse.");
        }

        public async Task<bool> RestartInstance(string token)
        {
            using var response = await _http.GetAsync($"restart");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(jsonResponse);
            if (jsonDoc.RootElement.TryGetProperty("value", out var valueElement))
            {
                return valueElement.GetBoolean();
            }

            throw new Exception("Failed to find 'value' property in the response content.");
        }

        public async Task<bool> UpdateAutoReadMessage(bool value)
        {
            var requestBody = new { value };
            using var response = await _http.PutAsJsonAsync($"update-auto-read-message", requestBody);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(jsonResponse);
            if (jsonDoc.RootElement.TryGetProperty("value", out var valueElement))
            {
                return valueElement.GetBoolean();
            }

            throw new Exception("Failed to find 'value' property in the response content.");
        }

        public async Task Disconnect(string instanceId, string token)
        {
            using var response = await _http.GetAsync($"disconnect");
            response.EnsureSuccessStatusCode();
        }
    }
}
