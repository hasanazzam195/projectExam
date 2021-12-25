using Microsoft.EntityFrameworkCore.Migrations;

namespace SecoundExam.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedNo",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "BedNo",
                table: "patiants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedNo",
                table: "patiants");

            migrationBuilder.AddColumn<int>(
                name: "BedNo",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
