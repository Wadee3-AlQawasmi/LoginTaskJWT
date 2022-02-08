using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAUTH.Migrations
{
    public partial class init13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classUsers_AspNetUsers_User_ID",
                table: "classUsers");

            migrationBuilder.DropIndex(
                name: "IX_classUsers_Class_ID",
                table: "classUsers");

            migrationBuilder.AlterColumn<string>(
                name: "User_ID",
                table: "classUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_classUsers",
                table: "classUsers",
                columns: new[] { "Class_ID", "User_ID" });

            migrationBuilder.AddForeignKey(
                name: "FK_classUsers_AspNetUsers_User_ID",
                table: "classUsers",
                column: "User_ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classUsers_AspNetUsers_User_ID",
                table: "classUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classUsers",
                table: "classUsers");

            migrationBuilder.AlterColumn<string>(
                name: "User_ID",
                table: "classUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_classUsers_Class_ID",
                table: "classUsers",
                column: "Class_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_classUsers_AspNetUsers_User_ID",
                table: "classUsers",
                column: "User_ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
