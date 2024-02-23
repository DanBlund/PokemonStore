using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonStore.Migrations
{
    /// <inheritdoc />
    public partial class ModelsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Pokemons");
        }
    }
}
