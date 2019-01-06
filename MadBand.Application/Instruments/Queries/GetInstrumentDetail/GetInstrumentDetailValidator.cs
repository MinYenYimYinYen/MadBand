using FluentValidation;

namespace MadBand.Application.Instruments.Queries.GetInstrumentDetail
{
	public class GetInstrumentDetailValidator : AbstractValidator<GetInstrumentDetailQuery>
	{
		public GetInstrumentDetailValidator()
		{
			RuleFor(v => v.Id).NotEmpty();
		}
	}
}
