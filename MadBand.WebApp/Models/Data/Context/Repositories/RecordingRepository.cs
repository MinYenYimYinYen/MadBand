using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories
{
	public class RecordingRepository : AbstractRepository<Recording>
	{
		public RecordingRepository(MadBandDbContext context) : base(context)
		{
		}

		protected override DbSet<Recording> _dbSet => _context.Recordings;


	}
}
