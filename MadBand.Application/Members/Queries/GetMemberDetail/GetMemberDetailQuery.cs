using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class GetMemberDetailQuery:IRequest<MemberDetailModel>
	{
		public string Id { get; set; }
	}
}
