using Microsoft.EntityFrameworkCore.Migrations;

namespace Activity.API.Migrations
{
    public partial class addedActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActivityName",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityName",
                table: "Activities");
        }
    }
}
