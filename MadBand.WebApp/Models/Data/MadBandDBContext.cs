﻿using MadBand.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;



namespace MadBand.WebApp.Models
{
	public class MadBandDbContext : DbContext
	{
		public MadBandDbContext(DbContextOptions<MadBandDbContext> options)
			:base(options)
		{
			
		}

		public DbSet<Instrument> Instruments { get; set; }
		public DbSet<InstrumentSong> InstrumentSongs { get; set; }
		public DbSet<Member> Members { get; set; }
		public DbSet<MemberInstrument> MemberInstruments { get; set; }
		public DbSet<MemberSong>MemberSongs{ get; set; }
		public DbSet<Recording> Recordings { get; set; }
		public DbSet<RecordingType> RecordingTypes { get; set; }
		public DbSet<Song> Songs { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(MadBandDbContext).Assembly);
		}
	}
}
