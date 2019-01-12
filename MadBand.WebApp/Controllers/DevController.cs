using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadBand.WebApp.Models;
using MadBand.WebApp.Models.Entities;
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

		public string ResetAndSeedDataBase()
		{


			var Luke = _context.Members.Add(new Member
			{
				FirstName = "Luke",
				LastName = "Holker"
			});

			var Kevin = _context.Members.Add(new Member
			{
				FirstName = "Kevin",
				LastName = "Holker"
			});

			var BassGuitar = _context.Instruments.Add(new Instrument
			{
				Name = "Bass Guitar"
			});

			var Harmonica = _context.Instruments.Add(new Instrument
			{
				Name = "Harmonica"
			});

			_context.SaveChanges();

			_context.MemberInstruments.Add(new MemberInstrument
			{
				Member = _context.GetMember("Luke"),
				Instrument = _context.GetInstrument("Bass Guitar")
			});

			_context.MemberInstruments.Add(new MemberInstrument
			{
				Member = _context.GetMember("Kevin"),
				Instrument = _context.GetInstrument("Harmonica")
			});



			//
			_context.SaveChanges();

			return "Database seeded.  Go check you fuckin animal.";
		}
    }
}