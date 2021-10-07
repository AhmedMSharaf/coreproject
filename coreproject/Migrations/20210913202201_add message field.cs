using Microsoft.EntityFrameworkCore.Migrations;

namespace coreproject.Migrations
{
    public partial class addmessagefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "contactU",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "contactU");
        }
    }
}
