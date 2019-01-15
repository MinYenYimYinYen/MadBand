using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
	public class SongController : Controller
	{
		private readonly SongRepository _repository;
		public SongController(IRepository<Song> repository)
		{
			_repository = (SongRepository)repository;
		}

		public IActionResult Index()
		{
			return View(_repository.GetAll());
		}

		public async Task<IActionResult> Create(Song song)
		{
			if (await TryUpdateModelAsync(song, typeof(Song), ""))
			{
				song = _repository.Create(song);
			}

			return RedirectToAction("Index");
		}
	}
}