using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistance.Interfaces.CRUD
{
public	interface ICreate<TEntity>
	{
		bool CanCreate(TEntity entity);
		TEntity Create(TEntity entity);
	}
}
