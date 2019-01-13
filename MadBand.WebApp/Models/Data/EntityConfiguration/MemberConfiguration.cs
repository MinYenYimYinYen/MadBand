using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadBand.WebApp.Models.Data.EntityConfiguration
{
	public class MemberConfiguration : IEntityTypeConfiguration<Member>
	{
		public void Configure(EntityTypeBuilder<Member> member)
		{
			member.ToTable("Member");

			member.Property(m => m.Id)
				.HasColumnName(nameof(Member) + "Id");

			member.HasKey(m => m.Id);

			member.Property(m => m.FirstName)
				.HasMaxLength(32)
				.IsRequired();

			member.Property(m => m.LastName)
				.HasMaxLength(32);



		}
	}
}
