using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAUTH.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseUsers",
                columns: table => new
                {
                    User_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Course_ID = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_courseUsers_course_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_Course_ID",
                table: "courseUsers",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_courseUsers_User_ID",
                table: "courseUsers",
                column: "User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseUsers");
        }
    }
}
