using MadBand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MadBand.Application.Recordings.Queries.GetRecordingDetail
{
public	class RecordingDetailModel
	{
		public int Id { get; set; }
		public DateTime? TimeStamp { get; set; }
		public string Notes { get; set; }

		public static Expression<Func<Recording, RecordingDetailModel>> Projection => recording =>
		 new RecordingDetailModel
		 {
			 Id = recording.RecordingID,
			 Notes = recording.Notes,
			 TimeStamp = recording.TimeStamp
		 };

		public static RecordingDetailModel Create(Recording recording)
		{
			return Projection.Compile().Invoke(recording);
		}
	}
}
