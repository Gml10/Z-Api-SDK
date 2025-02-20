using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ZapiSdk.Contracts;
using ZapiSdk.Models;

namespace ZapiSdk
{
    internal class Contacts : IContacts
    {
        readonly HttpClient _http;

        public Contacts(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<IEnumerable<ZapiContact>> GetContacts(int page, int pageSize)
        {
            using var response = await _http.GetAsync($"contacts?page={page}&pageSize={pageSize}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<ZapiContact>>()
                ?? throw new Exception("Failed to deserialize the response content to ZapiContact list.");
        }

        public async Task<ZapiResponse> Add(IEnumerable<AddContactRequest> contacts)
        {
            var body = new StringContent(JsonSerializer.Serialize(contacts), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("contacts/add", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ZapiResponse>()
                ?? throw new Exception("Failed to deserialize the response content to ZapiResponse.");
        }

        public async Task<ZapiResponse> Remove(IEnumerable<string> phoneNumbers)
        {
            var body = new StringContent(JsonSerializer.Serialize(phoneNumbers), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("contacts/remove", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ZapiResponse>()
                ?? throw new Exception("Failed to deserialize the response content to ZapiResponse.");
        }

        public async Task<ZapiContact> GetMetadata(string phone)
        {
            using var response = await _http.GetAsync($"contacts/{phone}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ZapiContact>()
                ?? throw new Exception("Failed to deserialize the response content to ZapiContact.");
        }

        public async Task<string> GetProfilePicture(string phone)
        {
            using var response = await _http.GetAsync($"profile-picture?phone={phone}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(jsonResponse);
            if (jsonDoc.RootElement.TryGetProperty("link", out var linkElement))
            {
                return linkElement.GetString() ?? string.Empty;
            }

            throw new Exception("Failed to find 'link' property in the response content.");
        }

        public async Task<bool> CheckIfExists(string phone)
        {
            using var response = await _http.GetAsync($"phone-exists/{phone}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(jsonResponse);
            if (jsonDoc.RootElement.TryGetProperty("exists", out var linkElement))
            {
                return linkElement.GetBoolean();
            }

            throw new Exception("Failed to find 'exists' property in the response content.");
        }

        public async Task<IEnumerable<PhonesExistsInBatch>> CheckIfExistsInBatch(string[] phones)
        {
            var body = new StringContent(JsonSerializer.Serialize(phones), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("phone-exists-batch", body);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<PhonesExistsInBatch>>()
              ?? throw new Exception("Failed to deserialize the response content to ZapiContact.");
        }

        public async Task<bool> ModifyBlocked(ModifyBlockedRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(new
            {
                phones = request.Phone,
                blocked = request.Action.ToString().ToLower()
            }), Encoding.UTF8, "application/json");

            using var response = await _http.PostAsync("contacts/modify-blocked", body);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            using var jsonDoc = JsonDocument.Parse(jsonResponse);
            if (jsonDoc.RootElement.TryGetProperty("exists", out var linkElement))
            {
                return linkElement.GetBoolean();
            }

            throw new Exception("Failed to find 'value' property in the response content.");
        }

        public async Task<ZapiResponse> Report(string phone)
        {
            var body = new StringContent(JsonSerializer.Serialize(new { }), Encoding.UTF8, "application/json");

            using var response = await _http.PostAsync($"contacts/{phone}/report", body);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ZapiResponse>()
              ?? throw new Exception("Failed to deserialize the response content to ZapiResponse.");
        }
    }
}
