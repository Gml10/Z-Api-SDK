namespace ZapiSdk.Models
{
    public class SendAudioRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NUMERO Ex: 551199999999. IMPORTANTE Envie somente números, sem formatação ou máscara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Link do audio ou seu Base64
        /// </summary>
        public string Audio { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a próxima mensagem. (Ex "delayMessage": 5, ). O delay default caso não seja informado é de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai ficar com o status "Gravando áudio...". (Ex "delayTyping": 5, ). O delay default caso não seja informado é de 0
        /// </summary>
        public int? DelayTyping { get; set; }

        /// <summary>
        /// Define se será uma mensagem de visualização única ou não
        /// </summary>
        public bool? ViewOnce { get; set; }

        /// <summary>
        /// Se ativo, a request responderá imediatamente com sucesso e o processamento do arquivo será realizado em segundo plano. O envio pode ser verificado através do webhook de envio.
        /// </summary>
        public bool? Async { get; set; }

        /// <summary>
        /// Define se o áudio será enviado com ondas sonoras ou não
        /// </summary>
        public bool? Waveform { get; set; }
    }
    public class Messages
    {
        readonly HttpClient _http;

        public Messages(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<MessageSendResponse> SendText(SendTextRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-text", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> ForwardMessage(ForwardMessageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("forward-message", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendReaction(ForwardMessageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-reaction", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendImage(SendImageRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-image", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendSticker(SendStickerRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-sticker", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendGif(SendGifRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-gif", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }

        public async Task<MessageSendResponse> SendAudio(SendAudioRequest request)
        {
            var body = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            using var response = await _http.PostAsync("send-audio", body);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<MessageSendResponse>()
                 ?? throw new Exception("Failed to deserialize the response content to MessageSendResponse.");
        }
    }
}

