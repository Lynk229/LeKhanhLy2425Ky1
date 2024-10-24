using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeKhanhLy423.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Nhanvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    IDNV = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fullname = table.Column<string>(type: "TEXT", nullable: true),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false),
                    Chucvu = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.IDNV);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}
