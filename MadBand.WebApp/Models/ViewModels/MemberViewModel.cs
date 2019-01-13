using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MadBand.WebApp.Models.ViewModels
{
	public class MemberViewModel
	{
		private readonly MadBandDbContext _context;
		public MemberViewModel(MadBandDbContext context	)
		{
			_context = context;
			_context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
		}

		public Member	Member { get; set; }

		public IEnumerable<Instrument> Instruments => Member.MemberInstruments
			.AsEnumerable()
			.Select(mi => mi.Instrument);

		public IEnumerable<Instrument> UnplayedInstruments =>
			_context.Instruments
			.AsEnumerable()
			.Except(Instruments);
	}
}
