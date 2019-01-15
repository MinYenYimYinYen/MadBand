using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class MemberInstrumentConfiguration : IEntityTypeConfiguration<MemberInstrument>
	{
		public void Configure(EntityTypeBuilder<MemberInstrument> membInst)
		{
			membInst.ToTable("MemberInstrument");

			membInst.HasKey(k => new { k.MemberId, k.InstrumentId });

			membInst.Property(mi => mi.MemberId)
				.HasColumnName(nameof(Member) + "ID");

			membInst.Property(mi => mi.InstrumentId)
				.HasColumnName(nameof(Instrument) + "ID");

			membInst.HasOne(e => e.Member)
				.WithMany(e => e.MemberInstruments)
				.HasForeignKey(fk => fk.MemberId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberInstruments_Members");

			membInst.HasOne(e => e.Instrument)
				.WithMany(e => e.MemberInstruments)
				.HasForeignKey(fk => fk.InstrumentId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberInstruments_Instruments");
		}
	}
}
