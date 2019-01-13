using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories
{
	public class SongRepository : AbstractRepository<Song>
	{
		public SongRepository(MadBandDbContext context) : base(context)
		{
		}

		protected override DbSet<Song> _dbSet => _context.Songs;
	}
}
