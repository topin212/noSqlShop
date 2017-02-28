using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using SherEShop.Utilities;


namespace SherEShop.Server
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage()
                .UseStaticFiles()
                .UseDefaultFiles();
            app.UseMvc(routes => { routes.MapRoute("default", "api/{controller=Entry}/{action=Index}/{id?}"); });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IOperableCollection, LiteWrap>();
        }
    }
}