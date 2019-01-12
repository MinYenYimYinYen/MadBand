using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class RecordingConfiguration : IEntityTypeConfiguration<Recording>
	{
		public void Configure(EntityTypeBuilder<Recording> recording)
		{
			recording.ToTable("Recording");

			recording.Property(e => e.RecordingId)
				.HasColumnName("RecordingID");

			recording.Property(r => r.MemberID)
				.HasColumnName(nameof(Member) + "Id")
				.IsRequired();

			recording.Property(r => r.SongId)
				.HasColumnName(nameof(Song)+"Id")
				.IsRequired();

			recording.Property(r => r.RecordingTypeId)
				.HasColumnName(nameof(RecordingType) + "Id")
				.IsRequired();

			recording.HasOne(r => r.RecordingType)
				.WithMany(r => r.Recordings)
				.IsRequired()
				.HasForeignKey(r => r.RecordingTypeId);

			recording.Property(r => r.Notes)
				.HasMaxLength(512);
		}
	}
}
