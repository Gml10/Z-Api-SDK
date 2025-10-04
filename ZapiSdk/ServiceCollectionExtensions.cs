using Microsoft.Extensions.DependencyInjection;
using ZApi.Contracts;

namespace ZapiSdk
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddZapiInstance(this IServiceCollection services, Func<ZApiConfigure> configure)
        {
            var config = configure();
    
            var baseUrl = string.Format("{0}{1}/token/{2}/", config.BaseUrl, config.Instance, config.Token);

            services.AddHttpClient("DefaultZApiInstance", client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            })
             .ConfigureHttpClient((serviceProvider, client) =>
             {
                 if (!string.IsNullOrEmpty(config.Token))
                     client.DefaultRequestHeaders.Add("Client-Token", config.Secret);
             });

            services.AddScoped<IZApi, ZApi>();

            return services;
        }
    }


}
