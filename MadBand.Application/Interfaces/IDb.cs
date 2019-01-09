using MadBand.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadBand.Application.Interfaces
{
	public interface IDb
	{
		DbSet<Instrument> Instruments { get; set; }
		DbSet<InstrumentSong> InstrumentSongs { get; set; }
		DbSet<MemberInstrument> MemberInstruments { get; set; }
		DbSet<Member> Members { get; set; }
		DbSet<MemberSong> MemberSongs { get; set; }
		DbSet<Recording> Recordings { get; set; }
		DbSet<RecordingType> RecordingTypes { get; set; }
		DbSet<Song> Songs { get; set; }
	}
}