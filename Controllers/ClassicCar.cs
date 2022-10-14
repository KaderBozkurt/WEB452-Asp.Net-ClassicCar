using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace ClassicCar.Controllers
{
    public class ClassicCar : Controller
    {

        //GET: /ClassicCar/
        public IActionResult Index()
        {
            return View();
        }
        //GET: /ClassicCar/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}


