using MadBand.WebApp.Models.Data.Context.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Entities
{
	public class RecordingType:IIdentifiable
	{
		public RecordingType()
		{
			Recordings = new HashSet<Recording>();
		}

		public int Id { get; set; }
		public string Type { get; set; }
		public string Notes { get; set; }
		public ICollection<Recording> Recordings { get; private set; }

	}
}
