using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace DevDayCoreFeatures.Web.Middleware
{
    public class ErrorMiddleware
    {
        private RequestDelegate nextMiddleware;

        public ErrorMiddleware(RequestDelegate next) {
            nextMiddleware = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            await nextMiddleware.Invoke(httpContext);

            if (httpContext.Response.StatusCode == 200)
                await httpContext.Response.WriteAsync("No errors detected!", Encoding.UTF8);

            // Add additional error checks
        }
    }
}
