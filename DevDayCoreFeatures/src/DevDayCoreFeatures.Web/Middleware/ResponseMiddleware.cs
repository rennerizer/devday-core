using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace DevDayCoreFeatures.Web.Middleware
{
    public class ResponseMiddleware
    {
        private RequestDelegate nextMiddleware;

        public ResponseMiddleware(RequestDelegate next) {
            nextMiddleware = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            if (httpContext.Request.Path.ToString().ToLower() == "/unique")
                await httpContext.Response.WriteAsync("This is a unique request");
            else
                await nextMiddleware.Invoke(httpContext);
        }
    }
}
