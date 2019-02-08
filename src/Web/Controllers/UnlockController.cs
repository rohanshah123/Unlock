using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UnlockController : Controller
    {
        
        
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult ShowText()
            {
                return Content("Should be return. ");
            }
            public IActionResult ShowJSON()
            {
                return Json(new { name = "favorite year", quote = "This is my favorite year." });
            }
            public IActionResult ShowHTML()
            {
                var h = "<!DOCTYPE html><html><body>An awesome phone" +
                "<br><br> <a href='/Quote'>Go Back to Unlock</a></body></html>";
                return Content(h, "text/html");
            }

            public IActionResult ShowView()
            {
                return View();
            }

            
        }
    }



 