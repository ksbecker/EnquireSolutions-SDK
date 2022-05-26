using Microsoft.Extensions.DependencyInjection;

using Refit;

namespace EnquireSolutions.Sdk
{
    public static class ServiceCollectionExtensions
    {
        public static IHttpClientBuilder AddEnquireSolutionsApiClient(this IServiceCollection services, Action<HttpClient> configureClient)
        {
            var settings = new RefitSettings(new NewtonsoftJsonContentSerializer());

            return services.AddRefitClient<IEnquireSolutionsApiClient>(settings)
                .ConfigureHttpClient((httpClient) =>
                {
                    EnquireSolutionsClientFactory.ConfigureHttpClientCore(httpClient);
                    configureClient(httpClient);
                });
        }
    }
}
