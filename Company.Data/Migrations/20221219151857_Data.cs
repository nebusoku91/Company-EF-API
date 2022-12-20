using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Employees_EmployeeID",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Companies_ACompanyID",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Positions_EmployeeID",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Positions");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "ACompanys");

            migrationBuilder.RenameColumn(
                name: "Organizationnumber",
                table: "ACompanys",
                newName: "OrganizationNumber");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ACompanys",
                table: "ACompanys",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "EmployeePosition",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePosition", x => new { x.EmployeesID, x.PositionID });
                    table.ForeignKey(
                        name: "FK_EmployeePosition_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePosition_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ACompanys",
                columns: new[] { "ID", "ACompanyName", "OrganizationNumber" },
                values: new object[,]
                {
                    { 1, "Företag 1", 115435 },
                    { 2, "Företag 2", 234534 },
                    { 3, "Företag 3", 99482 }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "ID", "PositionName" },
                values: new object[,]
                {
                    { 1, "Position 1" },
                    { 2, "Position 2" },
                    { 3, "Position 3" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "ACompanyID", "SectionName" },
                values: new object[] { 1, 3, "Avdelning 1" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "ACompanyID", "SectionName" },
                values: new object[] { 2, 1, "Avdelning 2" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "ACompanyID", "SectionName" },
                values: new object[] { 3, 2, "Avdelning 3" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "FirstName", "LastName", "Salary", "SectionID", "Union" },
                values: new object[] { 1, "John", "Doe", 5000, 1, true });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "FirstName", "LastName", "Salary", "SectionID", "Union" },
                values: new object[] { 2, "Matt", "Damon", 9000, 3, false });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "FirstName", "LastName", "Salary", "SectionID", "Union" },
                values: new object[] { 3, "Margot", "Robbie", 13000, 2, true });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeeID", "PositionID" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeeID", "PositionID" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "EmployeeID", "PositionID" },
                values: new object[] { 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePosition_PositionID",
                table: "EmployeePosition",
                column: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_ACompanys_ACompanyID",
                table: "Sections",
                column: "ACompanyID",
                principalTable: "ACompanys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_ACompanys_ACompanyID",
                table: "Sections");

            migrationBuilder.DropTable(
                name: "EmployeePosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ACompanys",
                table: "ACompanys");

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumns: new[] { "EmployeeID", "PositionID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ACompanys",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ACompanys",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ACompanys",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "ACompanys",
                newName: "Companies");

            migrationBuilder.RenameColumn(
                name: "OrganizationNumber",
                table: "Companies",
                newName: "Organizationnumber");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_EmployeeID",
                table: "Positions",
                column: "EmployeeID");

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
    }
}
