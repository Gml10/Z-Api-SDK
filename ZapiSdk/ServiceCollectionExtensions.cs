using Microsoft.Extensions.DependencyInjection;

namespace ZapiSdk
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddZapiInstance(this IServiceCollection services, Action<ZApiConfigure> configure)
        {
            var config = new ZApiConfigure();
            configure(config);

            var baseUrl = string.Format("{0}/token/{1}/", config.BaseUrl, config.Instance, config.Token);

            services.AddHttpClient("DefaultZApiInstance", client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            })
             .ConfigureHttpClient((serviceProvider, client) =>
             {
                 if (!string.IsNullOrEmpty(config.Token))
                     client.DefaultRequestHeaders.Add("Client-Token", config.Token);
             });

            return services;
        }
    }


}
