using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Domain.Entities
{
	public class Song
	{
		public Song()
		{
			InstrumentMembers = new HashSet<Member>();
			InstrumentSongs = new HashSet<InstrumentSong>();
			Recordings = new HashSet<Recording>();
		}

		public int SongID { get; set; }
		public string Title { get; set; }
		public ICollection<Member> InstrumentMembers { get; private set; }
		public ICollection<InstrumentSong> InstrumentSongs{ get; private set; }
		public ICollection<Recording> Recordings { get; private set; }


	}
}
