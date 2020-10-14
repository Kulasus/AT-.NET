using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class MyFileMiddleware
    {
        private RequestDelegate next;

        public MyFileMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        { 
            string path = @"D:\Coding\AT-.NET-GIT\cv04-ASP_MVC\WebApplication\WebApplication\Files\elephant.jpg";
            string filePath = Path.Combine(path, context.Request.Path.Value.TrimStart('/'));
            if (!File.Exists(filePath))
            {
                await next.Invoke(context);
                return;
            }
            throw new Exception("Bruda osas");
            context.Response.Headers.Add("Content-Type", "image/jpeg");
            await context.Response.SendFileAsync(filePath);
        }
    }
}
