using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.EntityConfiguration
{
	public class InstrumentConfiguration : IEntityTypeConfiguration<Instrument>
	{
		public void Configure(EntityTypeBuilder<Instrument> instrument)
		{
			instrument.ToTable("Instrument");

			instrument.Property(e => e.Id).HasColumnName("InstrumentID");

			instrument.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(32);

			instrument.HasIndex(e => e.Name)
				.IsUnique();

			instrument.Property(i => i.Id)
				.HasColumnName("InstrumentID");

			instrument.HasMany(i => i.Recordings)
				.WithOne(r => r.Instrument)
				.HasForeignKey(f => f.InstrumentID);


				

		}
	}
}
