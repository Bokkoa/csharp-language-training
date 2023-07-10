using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Data.Migrations
{
    public partial class cleanarchitecture_bokkoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Videos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Videos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Streamers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Streamers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Streamers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Streamers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Directors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ActorVideos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ActorVideos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ActorVideos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "ActorVideos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "ActorVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Actors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Streamers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ActorVideos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ActorVideos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ActorVideos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ActorVideos");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "ActorVideos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Actors");
        }
    }
}
