using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MudBlazorWASM.Client.Utility
{
    public class UserStartup
    {
        public static void Configure(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddSingleton(new GradesUtilityService());
        }
        public class GradesUtilityService
        {
            public string Hello() => "Hello World from MyService!";
        }
    }
}
