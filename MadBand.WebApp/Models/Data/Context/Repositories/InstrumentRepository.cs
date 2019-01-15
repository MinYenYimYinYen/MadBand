using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Data.Context.Repositories.Abstraction;
using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories
{
	public class InstrumentRepository : AbstractRepository<Instrument>
	{
		public InstrumentRepository(MadBandDbContext context) : base(context)
		{
		}



		protected override DbSet<Instrument> _dbSet => _context.Instruments;

		public IEnumerable<Member> GetMembersWhoPlay(Instrument instrument)
		{
			return _context.MemberInstruments
				.Where(mi => mi.InstrumentId == instrument.Id)
				.Select(mi=>mi.Member)
				.AsEnumerable();
		}

	}
}
