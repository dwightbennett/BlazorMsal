using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Net.Http;

namespace MsalBlazor
{
    public class Startup
    {
        public static string ClientId = "";
        public static string RedirectUri = "";
        public static string Authority = "";
        public static List<string> Scopes = new List<string>
        {

        };

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPublicClientApplication>(e =>
            {
                return PublicClientApplicationBuilder.Create(ClientId)
                .WithRedirectUri(RedirectUri)
                .WithAuthority(Authority)
                .WithHttpClientFactory(new MyHttpClientFactory(e.GetRequiredService<HttpClient>()))
                .Build();
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");            
        }
    }    
}
