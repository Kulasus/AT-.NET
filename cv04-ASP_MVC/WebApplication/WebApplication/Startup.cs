using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ExceptionHandler>();
            services.AddScoped<ILogger,JsonLogger>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseMiddleware<BrowserAuthMiddleware>();

            app.UseMiddleware<FormMiddleware>();

            app.UseMiddleware<MyFileMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<html>");
                    sb.Append("<head>");
                    sb.Append("<title>");
                    sb.Append("Titulek stránky");
                    sb.Append("</title>");
                    sb.Append("</head>");
                    sb.Append("<body>");
                    sb.Append("<h1>Nadpis</h1>");
                    sb.Append("</body>");
                    sb.Append("</html>");

                    context.Response.Headers.Add("Content-Type", "text/html; charset=utf-8");

                    await context.Response.WriteAsync(sb.ToString());
                });
            });
        }
    }
}
