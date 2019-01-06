using MadBand.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.Persistance.Configuration
{
	public class InstrumentConfiguration : IEntityTypeConfiguration<Instrument>
	{
		public void Configure(EntityTypeBuilder<Instrument> builder)
		{
			builder.Property(e => e.IntrumentID).HasColumnName("InstrumentID");

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(32);

			builder.HasIndex(e => e.Name)
				.IsUnique();
				

		}
	}
}
