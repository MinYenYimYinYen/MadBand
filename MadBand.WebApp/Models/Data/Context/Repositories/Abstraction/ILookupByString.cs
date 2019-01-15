using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.Context.Repositories.Abstraction
{
public	interface ILookupByString<TEntity>:IRepository<TEntity>
	{
		TEntity GetEntity(string lookupByString);
	}
}
