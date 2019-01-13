using MadBand.WebApp.Models.Data.Context.Repositories;
using MadBand.WebApp.Models.Data.Context.Repositories.Abstraction;
using System;

namespace MadBand.WebApp.Models.Entities
{
	public class Recording:IIdentifiable
	{
		public int Id { get; set; }
		public DateTime? TimeStamp { get; set; }
		public string Notes { get; set; }

		public int SongId { get; set; }
		public Song Song { get; set; }

		public int MemberID { get; set; }
		public Member Member { get; set; }


		public int InstrumentID { get; set; }
		public Instrument Instrument { get; set; }

		public int RecordingTypeId { get; set; }
		public RecordingType RecordingType { get; set; }
	}
}
