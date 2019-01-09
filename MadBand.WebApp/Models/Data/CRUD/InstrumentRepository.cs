using MadBand.WebApp.Interfaces.Data.CRUD;
using MadBand.WebApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.CRUD
{
	public class InstrumentRepository : IRepository<Instrument>
	{
		public bool CanCreate(Instrument entity)
		{
			throw new NotImplementedException();
		}

		public bool CanUpdate(Instrument entity)
		{
			throw new NotImplementedException();
		}

		public Instrument Create(Instrument entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(Instrument entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Instrument> GetEntities()
		{
			throw new NotImplementedException();
		}

		public Instrument GetEntity(int Id)
		{
			throw new NotImplementedException();
		}

		public Instrument Update(Instrument entity)
		{
			throw new NotImplementedException();
		}
	}
}
