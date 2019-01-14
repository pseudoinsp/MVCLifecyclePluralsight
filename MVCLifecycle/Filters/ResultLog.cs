using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLifecycle.Filters
{
    public class ResultLog : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("After the result exection");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Debug.WriteLine("Before the result exection");
        }
    }
}
