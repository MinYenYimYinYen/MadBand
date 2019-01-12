using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class Instrument
	{
		public Instrument()
		{
			InstrumentSongs = new HashSet<InstrumentSong>();
			MemberInstruments = new HashSet<MemberInstrument>();
			Recordings = new HashSet<Recording>();
		}

		public int InstrumentID { get; set; }
		public string Name{ get; set; }

		public ICollection<InstrumentSong	> InstrumentSongs{ get; private set; }
		public ICollection<MemberInstrument> MemberInstruments { get; private set; }
		public ICollection<Recording> Recordings{ get; private set; }
	}
}
