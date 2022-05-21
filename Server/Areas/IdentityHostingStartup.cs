using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(MudBlazorWASM.Server.Areas.Identity.IdentityHostingStartup))]
namespace MudBlazorWASM.Server.Areas.Identity
{
    public class IdentityHostingStartup: IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            { 
            });
        }
    }
}
