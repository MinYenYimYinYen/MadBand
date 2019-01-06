using MadBand.Application.Exceptions;
using MadBand.Application.Interfaces;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Instruments.Queries.GetInstrumentDetail
{
	public class GetInstrumentDetailQueryHandler : IRequestHandler<GetInstrumentDetailQuery, InstrumentDetailModel>
	{
		private readonly IContext _context;
		public GetInstrumentDetailQueryHandler(IContext context)
		{
			_context = context;
		}

		public async Task<InstrumentDetailModel> Handle(GetInstrumentDetailQuery request, CancellationToken cancellationToken)
		{
			Instrument entity = await _context.Instruments
				.FindAsync(request.Id);

			if (entity == null)
			{
				throw new NotFoundException(nameof(Instrument), request.Id);
			}

			return new InstrumentDetailModel
			{
				Id = entity.IntrumentID,
				Name = entity.Name
			};
		}
	}
}
