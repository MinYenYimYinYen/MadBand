using MadBand.WebApp.Interfaces.Data.CRUD;
using MadBand.WebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.CRUD
{
	public class MemberRepository : IRepository<Member>
	{
		public bool CanCreate(Member entity)
		{
			throw new NotImplementedException();
		}

		public bool CanUpdate(Member entity)
		{
			throw new NotImplementedException();
		}

		public Member Create(Member entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Member entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Member> GetEntities()
		{
			throw new NotImplementedException();
		}

		public Member GetEntity(int Id)
		{
			throw new NotImplementedException();
		}

		public Member Update(Member entity)
		{
			throw new NotImplementedException();
		}
	}
}
