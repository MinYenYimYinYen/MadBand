using MadBand.Application.Exceptions;
using MadBand.Application.Interfaces;
using MadBand.Application.Members.Queries.GetMemberDetail;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class GetMemberDetailQueryHandler : IRequestHandler<GetMemberDetailQuery, MemberDetailModel>
	{
		private readonly IMadBandDbContext _context;
		public GetMemberDetailQueryHandler(IMadBandDbContext context)
		{
			_context = context;
		}

		public async Task<MemberDetailModel> Handle(GetMemberDetailQuery request, CancellationToken cancellationToken)
		{
			Member entity = await _context.Members
				.FindAsync(request.Id);

			if (entity == null)
			{
				throw new NotFoundException(nameof(Member), request.Id);
			}

			return new MemberDetailModel
			{
				Id = entity.MemberID,
				FirstName = entity.FirstName,
				LastName = entity.LastName
			};
		}
	}
}

