using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordStore.DAL.Migrations
{
    public partial class OnCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecordDatas",
                columns: table => new
                {
                    category = table.Column<string>(nullable: false),
                    keyname = table.Column<string>(nullable: false),
                    value = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordDatas", x => new { x.category, x.keyname });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordDatas");
        }
    }
}
