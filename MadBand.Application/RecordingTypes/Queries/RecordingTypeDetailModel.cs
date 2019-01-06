using MadBand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MadBand.Application.RecordingTypes.Queries
{
public	class RecordingTypeDetailModel
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Notes { get; set; }

		public static Expression<Func<RecordingType, RecordingTypeDetailModel>> Projection => recordingType =>
		 new RecordingTypeDetailModel
		 {
			 Id = recordingType.RecordingTypeID,
			 Notes = recordingType.Notes,
			 Type = recordingType.Type
		 };

		public static RecordingTypeDetailModel Create(RecordingType recordingType)
		{
			return Projection.Compile().Invoke(recordingType);
		}
	}
}
