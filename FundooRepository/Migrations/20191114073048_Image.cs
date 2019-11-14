using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddImage",
                table: "notes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "collaborators",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SenderEmail = table.Column<string>(nullable: true),
                    Noteid = table.Column<string>(nullable: true),
                    ReceiverEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collaborators", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collaborators");

            migrationBuilder.DropColumn(
                name: "AddImage",
                table: "notes");
        }
    }
}
