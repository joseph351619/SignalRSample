using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SignalRSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseWebSockets();
            // app.UseSignalR(route =>
            // {
            //     route.MapHub<ChatHub>("/chathub");
            // });
            app.UseSignalR(route =>
            {
                route.MapHub<Chat>("/chat");
            });
            
        }
    }
}