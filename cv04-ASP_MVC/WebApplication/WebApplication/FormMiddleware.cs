using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication
{
    public class FormMiddleware
    {

        private RequestDelegate next;
        public FormMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path.Value == "/form")
            {
                string data = context.Request.Method == "POST" ? context.Request.Form["data"].ToString() : null;

                if (!string.IsNullOrWhiteSpace(data))
                {
                    await context.Response.WriteAsync("Data: " + data);
                }

                StringBuilder sb = new StringBuilder();

                sb.Append("<form method=\"post\" action=\"\">");
                sb.Append("<input name=\"data\"/>");
                sb.Append("<button>odeslat</buton>");
                sb.Append("</form>");

                context.Response.Headers.Add("Content-Type", "text/html; charset=utf-8");
                await context.Response.WriteAsync(sb.ToString());
            }
            else
            {
                await next.Invoke(context);
            }
            
        }
    }
}
