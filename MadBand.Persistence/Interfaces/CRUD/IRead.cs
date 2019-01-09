using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Persistance.Interfaces.CRUD
{
	public interface IRead<TEntity>
	{
		TEntity GetEntity(int Id);
	}
}
