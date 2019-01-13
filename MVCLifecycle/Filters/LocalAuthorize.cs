using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLifecycle.Filters
{
    public class LocalAuthorize : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.Request.Host.Value.Contains("localhost"))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
