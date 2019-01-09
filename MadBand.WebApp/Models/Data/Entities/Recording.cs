using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class Recording
	{
		public int RecordingID { get; set; }
		public DateTime?  TimeStamp { get; set; }
		public string  Notes { get; set; }

		public Song Song { get; set; }
		public Member Member { get; set; }
		public Instrument Instrument { get; set; }
		public RecordingType RecordingType { get; set; }
	}
}
