using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class MemberSong
	{
		public int MemberID { get; set; }
		public int SongID { get; set; }

		public Member Member { get; set; }
		public Song Song { get; set; }

	}
}
