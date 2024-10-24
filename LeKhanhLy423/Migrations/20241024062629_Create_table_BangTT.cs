using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeKhanhLy423.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_BangTT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BangTT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangTT", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangTT");
        }
    }
}
