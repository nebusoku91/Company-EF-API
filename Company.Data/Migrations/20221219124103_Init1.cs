using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Employees_EmployeeID",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_EmployeeID",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Sections");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Positions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Union",
                table: "Employees",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Salary",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ACompanyID",
                table: "Sections",
                column: "ACompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeID",
                table: "Positions",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SectionID",
                table: "Employees",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Sections_SectionID",
                table: "Employees",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Employees_EmployeeID",
                table: "Positions",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Companies_ACompanyID",
                table: "Sections",
                column: "ACompanyID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Sections_SectionID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Employees_EmployeeID",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Companies_ACompanyID",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_ACompanyID",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Positions_EmployeeID",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SectionID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "Union",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_EmployeeID",
                table: "Sections",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Employees_EmployeeID",
                table: "Sections",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID");
        }
    }
}
