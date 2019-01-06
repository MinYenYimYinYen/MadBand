using MadBand.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Persistance.Configuration
{
	public class InstrumentSongConfiguration : IEntityTypeConfiguration<InstrumentSong>
	{
		public void Configure(EntityTypeBuilder<InstrumentSong> builder)
		{
			builder.HasKey(e => new { e.InstrumentID, e.SongID });

			builder.Property(e => e.InstrumentID)
				.HasColumnName("IntrumentID");

			builder.Property(e => e.SongID)
				.HasColumnName("SongID");

			builder.HasOne(e => e.Instrument)
				.WithMany(e => e.InstrumentSongs)
				.HasForeignKey(e => e.InstrumentID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InstrumentSongs_Instruments");

			builder.HasOne(d => d.Song)
				.WithMany(p => p.InstrumentSongs)
				.HasForeignKey(d => d.SongID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_InstrumentSongs_Songs");
		}
	}
}
