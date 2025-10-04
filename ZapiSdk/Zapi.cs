using System.Text.Json;
using System.Text.Json.Serialization;
using ZApi.Contracts;

namespace ZapiSdk
{
    internal class ZApi : IZApi
    {
        HttpClient _http { get; set; }

        public IMessages Messages { get; init; }
        public IContacts Contacts { get; init; }
        public IInstance Instance { get; init; }

        public ZApi(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient("DefaultZApiInstance");

            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            Messages = new Messages(_http, jsonSerializerOptions);
            Contacts = new Contacts(_http, jsonSerializerOptions);
            Instance = new Instance(_http, jsonSerializerOptions);
        }
    }
}
