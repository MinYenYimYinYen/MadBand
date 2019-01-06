using MadBand.Application.Exceptions;
using MadBand.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class GetMemberDetailQueryHandler : IRequestHandler<GetMemberDetailQuery, MemberDetailModel>
	{
		public Task<MemberDetailModel> Handle(GetMemberDetailQuery request, CancellationToken cancellationToken)
		{
			throw new System.NotImplementedException();
		}
	}
}
