using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class GetMemberDetailValidator:AbstractValidator<GetMemberDetailQuery>
	{
		public GetMemberDetailValidator()
		{
			RuleFor(v => v.Id).NotEmpty();

		}
	}
}
