using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Data.Context.Repositories.Abstraction;
using MadBand.WebApp.Models.Data.Context.Repositories.Exceptions;
using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories
{
	public class MemberRepository : AbstractRepository<Member>,ILookupByString<Member>
	{
		public MemberRepository(MadBandDbContext context) : base(context)
		{

		}

		protected override DbSet<Member> _dbSet => _context.Members;

		public Member GetEntity(string firstName)
		{
			try
			{
				return _context.Members.Where(m => m.FirstName == firstName).First();
			}
			catch (Exception)
			{
				throw new MultipleEntitiesReturnedException(firstName);
			}
		}

		
	}
}
