using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BandBlender.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBandIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Musicians");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Musicians",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BandId",
                table: "Musicians",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MusicianId",
                table: "Musicians",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<List<Guid>>(
                name: "BandIds",
                table: "Musicians",
                type: "uuid[]",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Musicians",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Musicians",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Demo",
                table: "Musicians",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "Musicians",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InstrumentId",
                table: "Musicians",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Bands",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DemoUrl",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "BandId",
                table: "Bands",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians",
                column: "MusicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "MusicianId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "BandIds",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "Demo",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "InstrumentId",
                table: "Musicians");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Musicians",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "BandId",
                table: "Musicians",
                type: "integer",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Musicians",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Bands",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DemoUrl",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BandId",
                table: "Bands",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musicians",
                table: "Musicians",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
