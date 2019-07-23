using Microsoft.Identity.Client;
using System.Net.Http;

namespace MsalBlazor
{
    class MyHttpClientFactory : IMsalHttpClientFactory
    {
        public MyHttpClientFactory(HttpClient client)
        {
            Client = client;
        }

        public HttpClient Client { get; }

        public HttpClient GetHttpClient()
        {
            return Client;
        }
    }
}
