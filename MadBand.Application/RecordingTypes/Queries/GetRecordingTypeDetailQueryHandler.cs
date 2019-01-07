using MadBand.Application.Exceptions;
using MadBand.Application.Interfaces;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.RecordingTypes.Queries
{
	public class GetRecordingTypeDetailQueryHandler : IRequestHandler<GetRecordingTypeDetailQuery, RecordingTypeDetailModel>
	{
		private readonly IMadBandDbContext _context;

		public GetRecordingTypeDetailQueryHandler(IMadBandDbContext context)
		{
			_context = context;
		}

		public async Task<RecordingTypeDetailModel> Handle(GetRecordingTypeDetailQuery request, CancellationToken cancellationToken)
		{
			RecordingType entity = await _context.RecordingTypes
				.FindAsync(request.Id);

			if (entity == null)
			{
				throw new NotFoundException(nameof(RecordingType), request.Id);
			}

			return new RecordingTypeDetailModel
			{
				Id = entity.RecordingTypeID,
				Notes = entity.Notes,
				Type = entity.Type
			};
		}

	}
}
