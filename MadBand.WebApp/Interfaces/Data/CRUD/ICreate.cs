using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.WebApp.Interfaces.Data.CRUD
{
public	interface ICreate<TEntity>
	{
		bool CanCreate(TEntity entity);
		TEntity Create(TEntity entity);
	}
}
