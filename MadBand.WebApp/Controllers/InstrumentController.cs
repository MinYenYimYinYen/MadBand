using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MadBand.WebApp.Controllers
{
	public class InstrumentController : Controller
	{
		private readonly InstrumentRepository _repository;
		public InstrumentController(IRepository<Instrument> repository)
		{
			_repository = (InstrumentRepository)repository;
		}

		public IActionResult Index()
		{
			return View(_repository.GetAll());
		}

		public async Task<IActionResult> Create(Instrument instrument)
		{
			if( await TryUpdateModelAsync(instrument, typeof(Instrument), ""))
			{
				instrument = _repository.Create(instrument);
			}

			return RedirectToAction("Index");
		}
	}
}