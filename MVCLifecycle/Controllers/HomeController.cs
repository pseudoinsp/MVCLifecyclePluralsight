using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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


        public IActionResult Splash()
        {
            return Content("This is the splash page!");
        }
    }
}
