using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;

namespace MVCLifecycle.Filters
{
    public class LogAction : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action is executing");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Action has executed");
        }
    }
}
