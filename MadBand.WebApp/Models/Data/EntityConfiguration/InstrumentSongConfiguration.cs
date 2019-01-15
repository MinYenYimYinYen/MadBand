using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MadBand.WebApp.EntityConfiguration
{
	public class InstrumentSongConfiguration : IEntityTypeConfiguration<InstrumentSong>
	{
		public void Configure(EntityTypeBuilder<InstrumentSong> instSong)
		{
			instSong.ToTable("InstrumentSong");

			instSong.HasKey(e => new { e.InstrumentID, e.SongID });

			instSong.Property(e => e.InstrumentID)
				.HasColumnName(nameof(Instrument) + "Id");

			instSong.Property(e => e.SongID)
				.HasColumnName(nameof(Song) + "Id");

			instSong.HasOne(e => e.Instrument)
				.WithMany(e => e.InstrumentSongs)
				.HasForeignKey(e => e.InstrumentID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InstrumentSongs_Instruments");

			instSong.HasOne(d => d.Song)
				.WithMany(p => p.InstrumentSongs)
				.HasForeignKey(d => d.SongID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InstrumentSongs_Songs");
		}
	}
}
