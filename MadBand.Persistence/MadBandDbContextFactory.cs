using MadBand.Persistance;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistence
{
	public class MadBandDbContextFactory : IDesignTimeDbContextFactory<MadBandDbContext>
	{
		public MadBandDbContext CreateDbContext(string[] args)
		{
			throw new NotImplementedException();
		}
	}
}
