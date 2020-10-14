using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class ErrorHandlerMiddleware
    {
        private RequestDelegate next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context, ExceptionHandler handler)
        {
            try
            {
                await this.next.Invoke(context);
            }catch(Exception e)
            {
                await handler.Handle(e);
                await context.Response.WriteAsync("Došlo k chybě!");
            }
        }
    }
}
