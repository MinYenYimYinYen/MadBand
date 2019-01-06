using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Songs.Queries.GetSongDetail
{
	public class GetSongDetailValidator:AbstractValidator<GetSongDetailQuery>
	{
		public GetSongDetailValidator()
		{
			RuleFor(v => v.Id).NotEmpty();
		}
	}
}
