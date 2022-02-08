using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAUTH.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassesUser");

            migrationBuilder.DropTable(
                name: "UserCourse");

            migrationBuilder.DropTable(
                name: "classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_classes_AspNetUsers_username",
                        column: x => x.username,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_classes_course_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourse",
                columns: table => new
                {
                    ApplicationUser_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourse", x => new { x.ApplicationUser_Id, x.Course_Id });
                    table.ForeignKey(
                        name: "FK_UserCourse_AspNetUsers_ApplicationUser_Id",
                        column: x => x.ApplicationUser_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourse_course_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassesUser",
                columns: table => new
                {
                    ApplicationUser_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Classes_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesUser", x => new { x.ApplicationUser_Id, x.Classes_Id });
                    table.ForeignKey(
                        name: "FK_ClassesUser_AspNetUsers_ApplicationUser_Id",
                        column: x => x.ApplicationUser_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassesUser_classes_Classes_Id",
                        column: x => x.Classes_Id,
                        principalTable: "classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classes_Course_ID",
                table: "classes",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_classes_username",
                table: "classes",
                column: "username",
                unique: true,
                filter: "[username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesUser_Classes_Id",
                table: "ClassesUser",
                column: "Classes_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_Course_Id",
                table: "UserCourse",
                column: "Course_Id");
        }
    }
}
