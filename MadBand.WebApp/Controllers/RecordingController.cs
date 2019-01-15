using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
	public class RecordingController : Controller
	{
		private readonly RecordingRepository _repository;
		public RecordingController(IRepository<Recording> repository)
		{
			_repository = (RecordingRepository)repository;
		}

		public IActionResult Index()
		{
			return View(_repository.GetAll());
		}

		public async Task<IActionResult> Create(Recording recording)
		{
			if (await TryUpdateModelAsync(recording, typeof(Recording), ""))
			{
				recording = _repository.Create(recording);
			}

			return RedirectToAction("Index");
		}
	}
}