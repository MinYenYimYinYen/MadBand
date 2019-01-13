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
	public class RecordingTypeRepository : AbstractRepository<RecordingType>
	{
		public RecordingTypeRepository(MadBandDbContext context) : base(context)
		{
		}

		protected override DbSet<RecordingType> _dbSet => _context.RecordingTypes;
	}
}
