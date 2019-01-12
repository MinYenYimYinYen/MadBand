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

			membInst.HasKey(k => new { k.MemberID, k.InstrumentID });

			membInst.Property(mi => mi.MemberID)
				.HasColumnName(nameof(Member) + "ID");

			membInst.Property(mi => mi.InstrumentID)
				.HasColumnName(nameof(Instrument) + "ID");

			membInst.HasOne(e => e.Member)
				.WithMany(e => e.MemberInstruments)
				.HasForeignKey(fk => fk.MemberID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberInstruments_Members");

			membInst.HasOne(e => e.Instrument)
				.WithMany(e => e.MemberInstruments)
				.HasForeignKey(fk => fk.InstrumentID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MemberInstruments_Instruments");
		}
	}
}
