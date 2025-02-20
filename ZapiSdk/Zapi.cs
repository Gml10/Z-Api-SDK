using ZapiSdk.Contracts;

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

            Messages = new Messages(_http);
            Contacts = new Contacts(_http);
            Instance = new Instance(_http);
        }
    }
}
