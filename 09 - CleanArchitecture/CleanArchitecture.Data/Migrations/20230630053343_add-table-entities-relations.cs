using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Data.Migrations
{
    public partial class addtableentitiesrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorVideo_Actor_ActorId",
                table: "ActorVideo");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorVideo_Videos_VideoId",
                table: "ActorVideo");

            migrationBuilder.DropForeignKey(
                name: "FK_Director_Videos_VideoId",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorVideo",
                table: "ActorVideo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.RenameTable(
                name: "ActorVideo",
                newName: "ActorVideos");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_Director_VideoId",
                table: "Directors",
                newName: "IX_Directors_VideoId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorVideo_VideoId",
                table: "ActorVideos",
                newName: "IX_ActorVideos_VideoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorVideos",
                table: "ActorVideos",
                columns: new[] { "ActorId", "VideoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorVideos_Actors_ActorId",
                table: "ActorVideos",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorVideos_Videos_VideoId",
                table: "ActorVideos",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Videos_VideoId",
                table: "Directors",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorVideos_Actors_ActorId",
                table: "ActorVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorVideos_Videos_VideoId",
                table: "ActorVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Videos_VideoId",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActorVideos",
                table: "ActorVideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.RenameTable(
                name: "ActorVideos",
                newName: "ActorVideo");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_Directors_VideoId",
                table: "Director",
                newName: "IX_Director_VideoId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorVideos_VideoId",
                table: "ActorVideo",
                newName: "IX_ActorVideo_VideoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActorVideo",
                table: "ActorVideo",
                columns: new[] { "ActorId", "VideoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorVideo_Actor_ActorId",
                table: "ActorVideo",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorVideo_Videos_VideoId",
                table: "ActorVideo",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Videos_VideoId",
                table: "Director",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
