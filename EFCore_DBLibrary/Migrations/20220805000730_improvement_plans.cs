using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DBLibrary.Migrations
{
    public partial class improvement_plans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImprovementPlans",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(type: "int", nullable: false),
                    PlanStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImprovementPlans", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_ImprovementPlans_Employee_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImprovementPlans");
        }
    }
}
