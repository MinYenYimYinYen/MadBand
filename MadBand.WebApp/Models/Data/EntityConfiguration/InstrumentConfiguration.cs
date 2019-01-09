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
		public void Configure(EntityTypeBuilder<Instrument> builder)
		{
			builder.Property(e => e.InstrumentID).HasColumnName("InstrumentID");

			builder.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(32);

			builder.HasIndex(e => e.Name)
				.IsUnique();
				

		}
	}
}
