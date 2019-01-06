using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Recordings.Queries.GetRecordingDetail
{
public	class GetRecordingDetailValidator:AbstractValidator<GetRecordingDetailQuery>
	{
		public GetRecordingDetailValidator()
		{
			RuleFor(v => v.Id).NotEmpty();
		}
	}
}
