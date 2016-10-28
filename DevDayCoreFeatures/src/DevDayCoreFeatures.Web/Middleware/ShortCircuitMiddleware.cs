using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace DevDayCoreFeatures.Web.Middleware
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate nextDelegate;

        public ShortCircuitMiddleware(RequestDelegate next) {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            bool edge = httpContext.Request.Headers["User-Agent"].Any(h => h.ToLower().Contains("edge"));

            if (edge) {
                await httpContext.Response.WriteAsync("Edge is the best!");
            }
            else {
                await nextDelegate.Invoke(httpContext);
            }
        }
    }
}
