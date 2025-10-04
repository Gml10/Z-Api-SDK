using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ZApi;
using ZApi.Contracts;
using ZApi.Models;

namespace ZapiSdk
{
    internal class Messages : IMessages
    {
        readonly HttpClient _http;
        readonly JsonSerializerOptions _jsonOptions;

        public Messages(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions)
        {
            _http = httpClient;
            _jsonOptions = jsonSerializerOptions;
        }

        public async Task<MessageSendResponse> SendText(SendTextRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-text", body);
           
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                    ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
            }
            else
            {
               return (MessageSendResponse)await Utils.ProcessError(response);
            }
        }

        public async Task<MessageSendResponse> ForwardMessage(ForwardMessageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("forward-message", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendReaction(ForwardMessageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-reaction", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendImage(SendImageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-image", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendSticker(SendStickerRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-sticker", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendGif(SendGifRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-gif", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendAudio(SendAudioRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-audio", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendVideo(SendVideoRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-video", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendPtv(SendPtvRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-ptv", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendDocument(SendDocumentRequest request, string extension)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync($"send-document/{extension}", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendLink(SendLinkRequest request)
        {
            if (!request.Message.Contains(request.LinkUrl))
                request.Message += $" {request.LinkUrl}";

            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-link", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendLocation(SendLocationRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-location", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendProduct(SendProductRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-product", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendButtonOtp(SendButtonOtpRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-button-otp", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendButtonsAction(SendButtonActionRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request, _jsonOptions), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-button-actions", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>(_jsonOptions)
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }
    }
}
