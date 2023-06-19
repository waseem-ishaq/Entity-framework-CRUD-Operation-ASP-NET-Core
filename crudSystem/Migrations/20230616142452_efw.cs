using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crudSystem.Migrations
{
    /// <inheritdoc />
    public partial class efw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checkbox",
                table: "Employes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Checkbox",
                table: "Employes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
