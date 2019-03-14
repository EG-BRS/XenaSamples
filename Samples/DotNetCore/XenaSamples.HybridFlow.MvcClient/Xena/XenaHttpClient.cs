using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace XenaSamples.HybridFlow.MvcClient.Xena
{
    public class XenaHttpClient
    {
        private readonly string _xenaEndpoint;
        private static readonly HttpClient client = new HttpClient();

        public XenaHttpClient(string xenaEndpoint)
        {
            _xenaEndpoint = xenaEndpoint;
        }

        public async Task<string> GetAsyc(string accessToken, string apiEndPoint)
        {
           client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
           return await client.GetStringAsync($"{_xenaEndpoint}{apiEndPoint}");
        }

        public static XenaHttpClient Init(XenaApiOptions options)
        {
            var response = new XenaHttpClient(options.XenaEndpoint);
            return response;
        }
    }
}
