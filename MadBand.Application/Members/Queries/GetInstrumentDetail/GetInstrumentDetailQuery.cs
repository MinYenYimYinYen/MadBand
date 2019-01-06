using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetInstrumentDetail
{
	public class GetInstrumentDetailQuery:IRequest<InstrumentDetailModel>
	{
		public string Id { get; set; }
	}
}
