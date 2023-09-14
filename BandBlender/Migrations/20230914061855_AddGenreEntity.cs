using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BandBlender.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bands",
                table: "Bands");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bands",
                newName: "GenreId");

            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Musicians",
                type: "integer",
                nullable: true);

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
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Bands",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DemoUrl",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Bands",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ApplicationUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bands",
                table: "Bands",
                column: "BandId");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_BandId",
                table: "Musicians",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Bands_GenreId",
                table: "Bands",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musicians_Bands_BandId",
                table: "Musicians",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "BandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bands_Genres_GenreId",
                table: "Bands");

            migrationBuilder.DropForeignKey(
                name: "FK_Musicians_Bands_BandId",
                table: "Musicians");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Musicians_BandId",
                table: "Musicians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bands",
                table: "Bands");

            migrationBuilder.DropIndex(
                name: "IX_Bands_GenreId",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "DemoUrl",
                table: "Bands");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Bands");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Bands",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bands",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Bands",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ApplicationUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bands",
                table: "Bands",
                column: "Id");
        }
    }
}
