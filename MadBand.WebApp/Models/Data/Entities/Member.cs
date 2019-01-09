using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class Member
	{
		public Member()
		{
			Recordings = new HashSet<Recording>();
			InstrumentMembers = new HashSet<Member>();
			InstrumentSongs = new HashSet<InstrumentSong>();
		}

		public int MemberID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public ICollection<Recording> Recordings { get; private set; }
		public ICollection<Member>InstrumentMembers{ get; private set; }
		public ICollection<InstrumentSong>InstrumentSongs { get; private set; }



	}
}
