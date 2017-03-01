using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SherEShop.Server.MiddleWare;
using SherEShop.Utilities;


namespace SherEShop.Server
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage()
                .UseAuthorization()
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