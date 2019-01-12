using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class MemberSongConfiguration : IEntityTypeConfiguration<MemberSong>
	{
		public void Configure(EntityTypeBuilder<MemberSong> membSong)
		{
			membSong.ToTable("MemberSong");

			membSong.HasKey(e => new { e.MemberID, e.SongID });

			membSong.Property(p => p.MemberID)
				.HasColumnName(nameof(Member) + "Id");

			membSong.Property(p => p.SongID)
				.HasColumnName(nameof(Song) + "Id");

			membSong.HasOne(e => e.Member)
				.WithMany(e => e.MemberSongs)
				.HasForeignKey(e => e.MemberID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberSongs_Members");

			membSong.HasOne(e => e.Song)
				.WithMany(e => e.MemberSongs)
				.HasForeignKey(e => e.SongID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberSongs_Songs");

		}
	}
}
