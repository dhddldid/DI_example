using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DI_example.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Build WebAssemblyHost
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Specify Root Component (app.razor)
            builder.RootComponents.Add<App>("#app");

            // HttpClient Registered in DI Container
            // lifecycle, and setting up host-level services such as the HTTP server, dependency injection, logging, and configuration
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
