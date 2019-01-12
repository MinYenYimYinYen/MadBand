using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class SongConfiguration : IEntityTypeConfiguration<Song>
	{
		public void Configure(EntityTypeBuilder<Song> song)
		{
			song.ToTable("Song");

			song.Property(s => s.SongID)
				.HasColumnName(nameof(Song) + "Id");

			song.HasKey(s => s.SongID);

			song.HasMany(s => s.Recordings)
				.WithOne(r => r.Song)
				.HasForeignKey(fk => fk.SongId);

			song.Property(s => s.Title)
				.IsRequired()
				.HasMaxLength(128);
		}
	}
}
