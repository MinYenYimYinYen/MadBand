using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistance.Interfaces.CRUD
{
	interface IReadAll<TEntity>
	{
		IEnumerable<TEntity> GetEntities();
	}
}
