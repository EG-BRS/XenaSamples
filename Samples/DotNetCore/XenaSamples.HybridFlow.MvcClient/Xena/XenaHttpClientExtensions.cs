using Microsoft.Extensions.DependencyInjection;

namespace XenaSamples.HybridFlow.MvcClient.Xena
{
    public static class XenaHttpClientExtensions
    {
        public static void AddXenaAPI(this IServiceCollection services, string xenaAPIEndpoint)
        {
            services.AddSingleton(new XenaHttpClient(xenaAPIEndpoint));
        }
    }
}