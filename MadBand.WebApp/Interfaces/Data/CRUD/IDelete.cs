using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.WebApp.Interfaces.Data.CRUD
{
	public interface IDelete<TEntity>
	{
		bool Delete(TEntity entity);
	}
}
