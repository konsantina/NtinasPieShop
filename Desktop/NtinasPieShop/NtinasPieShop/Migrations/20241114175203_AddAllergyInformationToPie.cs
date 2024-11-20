using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NtinasPieShop.Migrations
{
    /// <inheritdoc />
    public partial class AddAllergyInformationToPie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AllergyInformation",
                table: "Pies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllergyInformation",
                table: "Pies");
        }
    }
}
