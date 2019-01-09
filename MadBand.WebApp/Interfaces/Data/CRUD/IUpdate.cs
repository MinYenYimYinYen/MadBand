using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.WebApp.Interfaces.Data.CRUD
{
public	interface IUpdate<TEntity>
	{
		bool CanUpdate(TEntity entity);
		TEntity Update(TEntity entity);
	}
}
