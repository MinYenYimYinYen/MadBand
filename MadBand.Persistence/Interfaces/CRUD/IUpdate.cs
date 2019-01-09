using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistance.Interfaces.CRUD
{
public	interface IUpdate<TEntity>
	{
		bool CanUpdate(TEntity entity);
		TEntity Update(TEntity entity);
	}
}
