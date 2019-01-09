using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class InstrumentSong
	{
		public int InstrumentID { get; set; }
		public int SongID { get; set; }

		public Instrument Instrument { get; set; }
		public Song Song { get; set; }

	}
}
