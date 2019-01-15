﻿// <auto-generated />
using System;
using MadBand.WebApp.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MadBand.WebApp.Migrations
{
    [DbContext(typeof(MadBandDbContext))]
    partial class MadBandDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InstrumentID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.InstrumentSong", b =>
                {
                    b.Property<int>("InstrumentID")
                        .HasColumnName("InstrumentId");

                    b.Property<int>("SongID")
                        .HasColumnName("SongId");

                    b.Property<int?>("MemberId");

                    b.HasKey("InstrumentID", "SongID");

                    b.HasIndex("MemberId");

                    b.HasIndex("SongID");

                    b.ToTable("InstrumentSong");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MemberId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("LastName")
                        .HasMaxLength(32);

                    b.Property<int?>("SongId");

                    b.HasKey("Id");

                    b.HasIndex("SongId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.MemberInstrument", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnName("MemberID");

                    b.Property<int>("InstrumentId")
                        .HasColumnName("InstrumentID");

                    b.HasKey("MemberId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("MemberInstrument");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.MemberSong", b =>
                {
                    b.Property<int>("MemberID")
                        .HasColumnName("MemberId");

                    b.Property<int>("SongID")
                        .HasColumnName("SongId");

                    b.HasKey("MemberID", "SongID");

                    b.HasIndex("SongID");

                    b.ToTable("MemberSong");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Recording", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecordingID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstrumentID");

                    b.Property<int>("MemberID")
                        .HasColumnName("MemberId");

                    b.Property<string>("Notes")
                        .HasMaxLength(512);

                    b.Property<int>("RecordingTypeId")
                        .HasColumnName("RecordingTypeId");

                    b.Property<int>("SongId")
                        .HasColumnName("SongId");

                    b.Property<DateTime?>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("InstrumentID");

                    b.HasIndex("MemberID");

                    b.HasIndex("RecordingTypeId");

                    b.HasIndex("SongId");

                    b.ToTable("Recording");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.RecordingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecordingTypeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("RecordingType");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.InstrumentSong", b =>
                {
                    b.HasOne("MadBand.WebApp.Models.Entities.Instrument", "Instrument")
                        .WithMany("InstrumentSongs")
                        .HasForeignKey("InstrumentID")
                        .HasConstraintName("FK_InstrumentSongs_Instruments");

                    b.HasOne("MadBand.WebApp.Models.Entities.Member")
                        .WithMany("InstrumentSongs")
                        .HasForeignKey("MemberId");

                    b.HasOne("MadBand.WebApp.Models.Entities.Song", "Song")
                        .WithMany("InstrumentSongs")
                        .HasForeignKey("SongID")
                        .HasConstraintName("FK_InstrumentSongs_Songs");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Member", b =>
                {
                    b.HasOne("MadBand.WebApp.Models.Entities.Song")
                        .WithMany("InstrumentMembers")
                        .HasForeignKey("SongId");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.MemberInstrument", b =>
                {
                    b.HasOne("MadBand.WebApp.Models.Entities.Instrument", "Instrument")
                        .WithMany("MemberInstruments")
                        .HasForeignKey("InstrumentId")
                        .HasConstraintName("FK_MemberInstruments_Instruments");

                    b.HasOne("MadBand.WebApp.Models.Entities.Member", "Member")
                        .WithMany("MemberInstruments")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK_MemberInstruments_Members");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.MemberSong", b =>
                {
                    b.HasOne("MadBand.WebApp.Models.Entities.Member", "Member")
                        .WithMany("MemberSongs")
                        .HasForeignKey("MemberID")
                        .HasConstraintName("FK_MemberSongs_Members");

                    b.HasOne("MadBand.WebApp.Models.Entities.Song", "Song")
                        .WithMany("MemberSongs")
                        .HasForeignKey("SongID")
                        .HasConstraintName("FK_MemberSongs_Songs");
                });

            modelBuilder.Entity("MadBand.WebApp.Models.Entities.Recording", b =>
                {
                    b.HasOne("MadBand.WebApp.Models.Entities.Instrument", "Instrument")
                        .WithMany("Recordings")
                        .HasForeignKey("InstrumentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MadBand.WebApp.Models.Entities.Member", "Member")
                        .WithMany("Recordings")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MadBand.WebApp.Models.Entities.RecordingType", "RecordingType")
                        .WithMany("Recordings")
                        .HasForeignKey("RecordingTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MadBand.WebApp.Models.Entities.Song", "Song")
                        .WithMany("Recordings")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
