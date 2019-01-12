using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadBand.WebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    InstrumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.InstrumentID);
                });

            migrationBuilder.CreateTable(
                name: "RecordingType",
                columns: table => new
                {
                    RecordingTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordingType", x => x.RecordingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 32, nullable: false),
                    LastName = table.Column<string>(maxLength: 32, nullable: true),
                    SongID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Member_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentSong",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(nullable: false),
                    SongId = table.Column<int>(nullable: false),
                    MemberID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentSong", x => new { x.InstrumentId, x.SongId });
                    table.ForeignKey(
                        name: "FK_InstrumentSongs_Instruments",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstrumentSong_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstrumentSongs_Songs",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberInstrument",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false),
                    InstrumentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberInstrument", x => new { x.MemberID, x.InstrumentID });
                    table.ForeignKey(
                        name: "FK_MemberInstruments_Instruments",
                        column: x => x.InstrumentID,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberInstruments_Members",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberSong",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    SongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSong", x => new { x.MemberId, x.SongId });
                    table.ForeignKey(
                        name: "FK_MemberSongs_Members",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberSongs_Songs",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recording",
                columns: table => new
                {
                    RecordingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(maxLength: 512, nullable: true),
                    SongId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    InstrumentID = table.Column<int>(nullable: false),
                    RecordingTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recording", x => x.RecordingID);
                    table.ForeignKey(
                        name: "FK_Recording_Instrument_InstrumentID",
                        column: x => x.InstrumentID,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recording_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recording_RecordingType_RecordingTypeId",
                        column: x => x.RecordingTypeId,
                        principalTable: "RecordingType",
                        principalColumn: "RecordingTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recording_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_Name",
                table: "Instrument",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentSong_MemberID",
                table: "InstrumentSong",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentSong_SongId",
                table: "InstrumentSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_SongID",
                table: "Member",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberInstrument_InstrumentID",
                table: "MemberInstrument",
                column: "InstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberSong_SongId",
                table: "MemberSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Recording_InstrumentID",
                table: "Recording",
                column: "InstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Recording_MemberId",
                table: "Recording",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Recording_RecordingTypeId",
                table: "Recording",
                column: "RecordingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recording_SongId",
                table: "Recording",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstrumentSong");

            migrationBuilder.DropTable(
                name: "MemberInstrument");

            migrationBuilder.DropTable(
                name: "MemberSong");

            migrationBuilder.DropTable(
                name: "Recording");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "RecordingType");

            migrationBuilder.DropTable(
                name: "Song");
        }
    }
}
