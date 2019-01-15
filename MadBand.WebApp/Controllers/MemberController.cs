using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MadBand.WebApp.Controllers
{
    public class MemberController : Controller
    {
		private readonly MemberRepository _repository;
		public MemberController(IRepository<Member> repository)
		{
			_repository = (MemberRepository)repository;
		}

		public IActionResult Index()
		{
			return View(_repository.GetAll());
		}

		public async Task<IActionResult> Create(Member member)
		{
			if (await TryUpdateModelAsync(member, typeof(Member), ""))
			{
				member = _repository.Create(member);
			}

			return RedirectToAction("Index");
		}
	}
}