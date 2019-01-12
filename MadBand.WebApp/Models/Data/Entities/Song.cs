using System.Collections.Generic;

namespace MadBand.WebApp.Models.Entities
{
	public class Song
	{
		public Song()
		{
			InstrumentMembers = new HashSet<Member>();
			InstrumentSongs = new HashSet<InstrumentSong>();
			Recordings = new HashSet<Recording>();
			MemberSongs = new HashSet<MemberSong>();
		}

		public int SongID { get; set; }
		public string Title { get; set; }
		public ICollection<Member> InstrumentMembers { get; private set; }
		public ICollection<InstrumentSong> InstrumentSongs { get; private set; }
		public ICollection<MemberSong> MemberSongs { get; private set; }
		public ICollection<Recording> Recordings { get; private set; }


	}
}
