using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace DevDayCoreFeatures.Web.Middleware
{
    public class ContextMiddleware
    {
        private RequestDelegate nextMiddleware;

        public ContextMiddleware(RequestDelegate next) {
            nextMiddleware = next;
        }

        public async Task Invoke(HttpContext httpContext) {
            httpContext.Items["Instructions"] = "This request requires special handling";

            await nextMiddleware.Invoke(httpContext);
        }
    }
}
