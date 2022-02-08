using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAUTH.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseUsers");

            migrationBuilder.CreateTable(
                name: "classUsers",
                columns: table => new
                {
                    User_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Class_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_classUsers_AspNetUsers_User_ID",
                        column: x => x.User_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classUsers_classes_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classUsers_Class_ID",
                table: "classUsers",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_classUsers_User_ID",
                table: "classUsers",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classUsers");

            migrationBuilder.CreateTable(
                name: "courseUsers",
                columns: table => new
                {
                    Class_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_courseUsers_AspNetUsers_User_ID",
                        column: x => x.User_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseUsers_classes_Class_ID",
                        column: x => x.Class_ID,
                        principalTable: "classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_Class_ID",
                table: "courseUsers",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_User_ID",
                table: "courseUsers",
                column: "User_ID");
        }
    }
}
