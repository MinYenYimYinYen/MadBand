using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class MemberInstrument
	{
		public int MemberID { get; set; }
		public int InstrumentID { get; set; }

		public Member Member { get; set; }
		public Instrument Instrument { get; set; }
	}
}
