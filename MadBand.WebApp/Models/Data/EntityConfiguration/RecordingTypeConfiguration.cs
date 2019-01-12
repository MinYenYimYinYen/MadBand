using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class RecordingTypeConfiguration : IEntityTypeConfiguration<RecordingType>
	{
		public void Configure(EntityTypeBuilder<RecordingType> recType)
		{
			recType.ToTable("RecordingType");

			recType.Property(e => e.RecordingTypeID)
				.HasColumnName(nameof(RecordingType) + "Id");

			recType.HasKey(r => r.RecordingTypeID);

			recType.HasMany(rt => rt.Recordings)
				.WithOne(r => r.RecordingType)
				.HasForeignKey(fk => fk.RecordingTypeId);
		}
	}
}
