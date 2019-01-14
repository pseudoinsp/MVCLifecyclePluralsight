using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLifecycle.Filters;
using MVCLifecycle.Models;

namespace MVCLifecycle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("PcIndex");
        }

        [ActionName("Index")]
        [IsMobile]
        public IActionResult IndexOnMobile()
        {
            return Content("MobileIndex");
        }

        [LocalAuthorize]
        public IActionResult Edit() => Content("Edit action method");

        [HttpPost]
        public IActionResult Edit(int id, string name) => Content("Edit post action method");

        [LogAction]
        public IActionResult Splash()
        {
            return Content("This is the splash page!");
        }

        [ResultLog]
        public IActionResult Splush()
        {
            return Content("This is the splush page!");
        }

        [ResultLog]
        public IActionResult GetCustomerData()
        {
            return Ok(new { Id = 3, FirstName = "Test", LastName = "Sample" });
        }
    }
}
