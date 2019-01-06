using MadBand.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.RecordingTypes.Queries
{
	public class GetRecordingTypeDetailQuery : IRequest<RecordingTypeDetailModel>, IQueryByID<int>
	{
		public int Id { get; set; }
	}
}
