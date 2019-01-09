﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadBand.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
    public class DevController : Controller
    {
		private readonly MadBandDbContext _context;
		public DevController(MadBandDbContext context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
            return View();
        }
    }
}