using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistance.Interfaces.CRUD
{
	public interface IDelete<TEntity>
	{
		bool Delete(TEntity entity);
	}
}
