using MadBand.Application.Interfaces;
using MadBand.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Recordings.Queries.GetRecordingDetail
{
	public class GetRecordingDetailQuery : IRequest<RecordingDetailModel>, IQueryByID<int>
	{
		public int Id { get; set; }
	}
}
