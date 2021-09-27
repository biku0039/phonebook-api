using Microsoft.EntityFrameworkCore.Migrations;

namespace ANZ104AngularDemo.Migrations
{
    public partial class Added_Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TenantId",
                table: "Persons",
                column: "TenantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
