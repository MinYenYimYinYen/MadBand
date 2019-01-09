using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.WebApp.Interfaces.Data.CRUD
{
public	interface IReadAll<TEntity>
	{
		IEnumerable<TEntity> GetEntities();
	}
}
