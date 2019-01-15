using MadBand.WebApp.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories.Abstraction
{
	public abstract class AbstractRepository<TEntityType> : IRepository<TEntityType>
		where TEntityType : class, IIdentifiable
	{
		protected abstract DbSet<TEntityType> _dbSet { get;}
		protected  MadBandDbContext _context;

		public AbstractRepository(MadBandDbContext context)
		{
			_context = context;
			_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}

		public virtual TEntityType Create(TEntityType entity)
		{
			entity = _dbSet.Add(entity).Entity;			
			_context.SaveChanges();
			_context.Entry(entity).State = EntityState.Detached;
			return entity;
		}

		public virtual TEntityType Delete(int id)
		{
			var entity = _dbSet.Find(id);
			_dbSet.Attach(entity);
			_dbSet.Remove(entity);
			_context.SaveChanges();
			return entity;
		}

		public virtual TEntityType Delete(TEntityType entity)
		{
			return Delete(entity.Id);
		}

		public virtual TEntityType GetEntity(int id)
		{
			return _dbSet.Find(id);
		}

		public virtual IEnumerable<TEntityType> GetAll()
		{
			return _dbSet.AsEnumerable();
		}

		public virtual void Update(TEntityType entity)
		{
			_dbSet.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
			_context.SaveChanges();
			_context.Entry(entity).State = EntityState.Detached;
		}
	}
}
