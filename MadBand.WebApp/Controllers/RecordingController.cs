using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
    public class RecordingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}