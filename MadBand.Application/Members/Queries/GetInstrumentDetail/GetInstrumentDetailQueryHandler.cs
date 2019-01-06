using MadBand.Application.Exceptions;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetInstrumentDetail
{
	public class GetInstrumentDetailQueryHandler : IRequestHandler<GetInstrumentDetailQuery, InstrumentDetailModel>
	{
		public Task<InstrumentDetailModel> Handle(GetInstrumentDetailQuery request, CancellationToken cancellationToken)
		{
			throw new System.NotImplementedException();
		}
	}
}
