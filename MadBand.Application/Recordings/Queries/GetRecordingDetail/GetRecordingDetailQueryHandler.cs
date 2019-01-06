using MadBand.Application.Exceptions;
using MadBand.Application.Interfaces;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Recordings.Queries.GetRecordingDetail
{
	public class GetRecordingDetailQueryHandler : IRequestHandler<GetRecordingDetailQuery, RecordingDetailModel>
	{
		private readonly IContext _context;
		public GetRecordingDetailQueryHandler(IContext context)
		{
			_context = context;
		}

		public async Task<RecordingDetailModel> Handle(GetRecordingDetailQuery request, CancellationToken cancellationToken)
		{
			Recording entity = await _context.Recordings
				.FindAsync(request.Id);

			if (entity == null)
			{
				throw new NotFoundException(nameof(Recording), request.Id);
			}

			return new RecordingDetailModel
			{
				Id = entity.RecordingID,
				Notes = entity.Notes,
				TimeStamp = entity.TimeStamp
			};
		}


	}
}
