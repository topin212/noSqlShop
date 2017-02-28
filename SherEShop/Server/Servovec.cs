using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Diagnostics;


namespace SherEShop.Server
{
    public class Servovec
    {
        private readonly IWebHost _webHost;

        public Servovec()
        {
            _webHost = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .UseContentRoot(Path.Combine(Directory.GetCurrentDirectory(), "kek"))
                .UseUrls("http://localhost:30001")
                .Build();
        }

        public void Run()
        {
            _webHost.Run();
        }
    }
}