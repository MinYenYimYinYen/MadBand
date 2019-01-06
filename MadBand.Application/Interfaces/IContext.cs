using MadBand.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadBand.Application.Interfaces
{
	public interface IContext
	{
		DbSet<Instrument> Instruments { get; set; }
		DbSet<Song> Songs { get; set; }
		DbSet<Member> Members { get; set; }
		DbSet<Recording> Recordings { get; set; }
		DbSet<InstrumentSong> InstrumentSongs { get; set; }
		DbSet<MemberInstrument> MemberInstruments { get; set; }
		DbSet<RecordingType> RecordingTypes { get; set; }
	}
}
