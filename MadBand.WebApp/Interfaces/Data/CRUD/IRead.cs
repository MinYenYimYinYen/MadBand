using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.WebApp.Interfaces.Data.CRUD
{
	public interface IRead<TEntity>
	{
		TEntity GetEntity(int Id);
	}
}
