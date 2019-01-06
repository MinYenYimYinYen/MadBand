using MadBand.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MadBand.Application.Instruments.Queries.GetInstrumentDetail
{
	public class InstrumentDetailModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public static Expression<Func<Instrument, InstrumentDetailModel>> Projection => instument => new InstrumentDetailModel
		{
			Id = instument.IntrumentID,
			Name = instument.Name
		};
		
		public static InstrumentDetailModel Create(Instrument instrument)
		{
			return Projection.Compile().Invoke(instrument);
		}
	}
}
