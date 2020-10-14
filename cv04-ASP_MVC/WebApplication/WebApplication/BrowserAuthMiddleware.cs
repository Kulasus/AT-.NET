using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class BrowserAuthMiddleware
    {
        private RequestDelegate next;
        public BrowserAuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string userAgent = context.Request.Headers["User-Agent"];
            if (userAgent.Contains("Chrome"))
            {
                await this.next.Invoke(context);
                return;
            }

            context.Response.Headers.Add("Content-Type", "text/html; charset=utf-8");
            await context.Response.WriteAsync("Použíjte chrome");
        }
    }
}
