using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class Data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ACompanys",
                columns: new[] { "ID", "ACompanyName", "OrganizationNumber" },
                values: new object[] { 1, "Företag 1", 115435 });

            migrationBuilder.InsertData(
                table: "ACompanys",
                columns: new[] { "ID", "ACompanyName", "OrganizationNumber" },
                values: new object[] { 2, "Företag 2", 234534 });

            migrationBuilder.InsertData(
                table: "ACompanys",
                columns: new[] { "ID", "ACompanyName", "OrganizationNumber" },
                values: new object[] { 3, "Företag 3", 99482 });

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
        }
    }
}
