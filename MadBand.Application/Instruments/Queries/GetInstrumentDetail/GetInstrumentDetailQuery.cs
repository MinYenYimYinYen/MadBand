using MadBand.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Application.Instruments.Queries.GetInstrumentDetail
{
	public class GetInstrumentDetailQuery:IRequest<InstrumentDetailModel>,IQueryByID<int>
	{
		public int Id { get; set; }
	}
}
