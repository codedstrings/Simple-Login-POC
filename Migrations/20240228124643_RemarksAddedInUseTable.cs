using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_Login_POC.Migrations
{
    /// <inheritdoc />
    public partial class RemarksAddedInUseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Users");
        }
    }
}
