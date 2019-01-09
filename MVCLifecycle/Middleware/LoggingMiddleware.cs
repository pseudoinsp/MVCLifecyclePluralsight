using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLifecycle.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate next;

        public LoggingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine("=== Logging before");
            await next.Invoke(context);
            Debug.WriteLine("=== Logging after");
        }
    }
}
