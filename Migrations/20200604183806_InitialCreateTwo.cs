using Microsoft.EntityFrameworkCore.Migrations;

namespace LabSUBD.Migrations
{
    public partial class InitialCreateTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Departaments_EmployeeId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Posts_EmployeeId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Specialties_EmployeeId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_EmployeeId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeInformations");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialtyId",
                table: "EmployeeInformations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DepartamentId",
                table: "EmployeeInformations",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_PostId",
                table: "EmployeeInformations",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SpecialtyId",
                table: "EmployeeInformations",
                column: "SpecialtyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Departaments_DepartamentId",
                table: "EmployeeInformations",
                column: "DepartamentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Posts_PostId",
                table: "EmployeeInformations",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Specialties_SpecialtyId",
                table: "EmployeeInformations",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Departaments_DepartamentId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Posts_PostId",
                table: "EmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInformations_Specialties_SpecialtyId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_DepartamentId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_PostId",
                table: "EmployeeInformations");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInformations_SpecialtyId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "EmployeeInformations");

            migrationBuilder.DropColumn(
                name: "SpecialtyId",
                table: "EmployeeInformations");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_EmployeeId",
                table: "EmployeeInformations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Departaments_EmployeeId",
                table: "EmployeeInformations",
                column: "EmployeeId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Posts_EmployeeId",
                table: "EmployeeInformations",
                column: "EmployeeId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_Specialties_EmployeeId",
                table: "EmployeeInformations",
                column: "EmployeeId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
