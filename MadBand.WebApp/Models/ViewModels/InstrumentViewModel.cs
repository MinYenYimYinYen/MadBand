using MadBand.WebApp.Models.Context;
using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MadBand.WebApp.Models.ViewModels
{
	public class InstrumentViewModel
	{

		private readonly InstrumentRepository _repository;

		public InstrumentViewModel(IRepository<Instrument> repository, Instrument instrument)
		{
			_repository = (InstrumentRepository)repository;
			Instrument = instrument;
		}

		public Instrument Instrument { get;private set; }

		public IEnumerable<Member> MembersWhoPlayMe => _repository.GetMembersWhoPlay(Instrument);

		

	}
}
