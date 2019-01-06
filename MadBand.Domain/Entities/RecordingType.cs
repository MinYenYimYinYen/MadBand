using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Domain.Entities
{
	public class RecordingType
	{
		public RecordingType()
		{
			Recordings = new HashSet<Recording>();
		}

		public int RecordingTypeID { get; set; }
		public string Type { get; set; }
		public string Notes { get; set; }
		public ICollection<Recording> Recordings { get; private set; }

	}
}
