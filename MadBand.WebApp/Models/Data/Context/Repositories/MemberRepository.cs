using MadBand.WebApp.Models.Context;
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

		//	private readonly MadBandDbContext _context;
		//	private readonly DbSet<Member> _dbSet;

		//	public MemberRepository(MadBandDbContext context, DbSet<Member> dbSet) : base(context, dbSet)
		//	{
		//		_context = context;
		//		_dbSet = dbSet;
		//	}

		//	//public MemberRepository(MadBandDbContext context, DbSet<Member> members)
		//	//{
		//	//	_context = context;
		//	//	_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		//	//}





		//	public override Member GetEntity(int id)
		//	{
		//		return _context.Members.Find(id);
		//	}

		//	public override void Update(Member member)
		//	{
		//		_context.Members.Attach(member);
		//		_context.Entry(member).State = EntityState.Modified;
		//		_context.SaveChanges();
		//		_context.Entry(member).State = EntityState.Detached;
		//	}

		//	public override Member Create(Member member)
		//	{
		//		member = _context.Members.Add(member).Entity;
		//		_context.SaveChanges();
		//		_context.Entry(member).State = EntityState.Detached;
		//		return member;
		//	}

		//	public override Member Delete(Member member)
		//	{			
		//		return Delete(member.Id);
		//	}

		//	public override Member Delete(int id)
		//	{
		//		var entity = _context.Members.Find(id);
		//		_context.Members.Attach(entity);
		//		_context.Members.Remove(entity);
		//		_context.SaveChanges();
		//		return entity;
		//	}
		//}

	}
}
