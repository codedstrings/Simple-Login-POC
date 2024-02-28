using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simple_Login_POC.Migrations
{
    /// <inheritdoc />
    public partial class addOTP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "otp",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "otp",
                table: "Users");
        }
    }
}
