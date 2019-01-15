using Microsoft.EntityFrameworkCore.Migrations;

namespace MadBand.WebApp.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentSong_Member_MemberID",
                table: "InstrumentSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Song_SongID",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "SongID",
                table: "Member",
                newName: "SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_SongID",
                table: "Member",
                newName: "IX_Member_SongId");

            migrationBuilder.RenameColumn(
                name: "MemberID",
                table: "InstrumentSong",
                newName: "MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentSong_MemberID",
                table: "InstrumentSong",
                newName: "IX_InstrumentSong_MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentSong_Member_MemberId",
                table: "InstrumentSong",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Song_SongId",
                table: "Member",
                column: "SongId",
                principalTable: "Song",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentSong_Member_MemberId",
                table: "InstrumentSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Song_SongId",
                table: "Member");

            migrationBuilder.RenameColumn(
                name: "SongId",
                table: "Member",
                newName: "SongID");

            migrationBuilder.RenameIndex(
                name: "IX_Member_SongId",
                table: "Member",
                newName: "IX_Member_SongID");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "InstrumentSong",
                newName: "MemberID");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentSong_MemberId",
                table: "InstrumentSong",
                newName: "IX_InstrumentSong_MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentSong_Member_MemberID",
                table: "InstrumentSong",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Song_SongID",
                table: "Member",
                column: "SongID",
                principalTable: "Song",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
