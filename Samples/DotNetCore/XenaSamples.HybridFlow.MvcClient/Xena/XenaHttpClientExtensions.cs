using Microsoft.Extensions.DependencyInjection;

namespace XenaSamples.HybridFlow.MvcClient.Xena
{
    public static class XenaHttpClientExtensions
    {
        public static void AddXenaAPI(this IServiceCollection services, XenaApiOptions options)
        {
            services.AddSingleton(XenaHttpClient.Init(options));
        }
    }
}