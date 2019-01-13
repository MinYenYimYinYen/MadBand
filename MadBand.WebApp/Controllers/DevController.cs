using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Data.Context.Repositories.Abstraction;
using MadBand.WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
	public class DevController : Controller
	{
		private readonly MadBandDbContext _context;
		private readonly ILookupByString<Member> _memberRepository;

		public DevController(MadBandDbContext context, IRepository<Member> memberRepository)
		{
			_context = context;
			_memberRepository = (ILookupByString<Member>)memberRepository;
		}
		public IActionResult Index()
		{
			return View();
		}

		public string ResetAndSeedDataBase()
		{
			_memberRepository.Create(new Member
			{
				FirstName = "Jimi",
				LastName = "Hendrix"
			});






			//_context.MemberInstruments.Add(new MemberInstrument
			//{
			//	Member = _memberRepository.GetEntity("Luke"),
			//	Instrument = _context.GetInstrument("Bass Guitar")
			//});

			//_context.MemberInstruments.Add(new MemberInstrument
			//{
			//	Member = _memberRepository.GetEntity("Kevin"),
			//	Instrument = _context.GetInstrument("Harmonica")
			//});



			//


			return "Database seeded.  Go check you fuckin animal.";
		}
	}
}