using FluentValidation;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class GetMemberDetailValidator : AbstractValidator<GetMemberDetailQuery>
	{
		public GetMemberDetailValidator()
		{
			RuleFor(v => v.Id).NotEmpty();

		}
	}
}
