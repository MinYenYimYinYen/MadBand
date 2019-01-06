using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.RecordingTypes.Queries
{
	public class GetRecordingTypeDetailQueryValidator:AbstractValidator<GetRecordingTypeDetailQuery>
	{
		public GetRecordingTypeDetailQueryValidator()
		{
			RuleFor(v => v.Id).NotEmpty();
		}
	}
}
