using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAUTH.Migrations
{
    public partial class init11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseUsers_course_Course_ID",
                table: "courseUsers");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "courseUsers",
                newName: "Class_ID");

            migrationBuilder.RenameIndex(
                name: "IX_courseUsers_Course_ID",
                table: "courseUsers",
                newName: "IX_courseUsers_Class_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_courseUsers_classes_Class_ID",
                table: "courseUsers",
                column: "Class_ID",
                principalTable: "classes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseUsers_classes_Class_ID",
                table: "courseUsers");

            migrationBuilder.RenameColumn(
                name: "Class_ID",
                table: "courseUsers",
                newName: "Course_ID");

            migrationBuilder.RenameIndex(
                name: "IX_courseUsers_Class_ID",
                table: "courseUsers",
                newName: "IX_courseUsers_Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_courseUsers_course_Course_ID",
                table: "courseUsers",
                column: "Course_ID",
                principalTable: "course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
