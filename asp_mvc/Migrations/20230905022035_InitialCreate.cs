using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp_mvc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chuc_vu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuc_vu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nhan_vien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    chucVuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhan_vien", x => x.id);
                    table.ForeignKey(
                        name: "FK_nhan_vien_chuc_vu_chucVuId",
                        column: x => x.chucVuId,
                        principalTable: "chuc_vu",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_nhan_vien_chucVuId",
                table: "nhan_vien",
                column: "chucVuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nhan_vien");

            migrationBuilder.DropTable(
                name: "chuc_vu");
        }
    }
}
