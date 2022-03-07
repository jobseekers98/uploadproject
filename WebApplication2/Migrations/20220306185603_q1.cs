using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class q1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateList");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "tbl_BindDropDown",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "tbl_BindDropDown");

            migrationBuilder.CreateTable(
                name: "StateList",
                columns: table => new
                {
                    Value = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeViewModelId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateList", x => x.Value);
                    table.ForeignKey(
                        name: "FK_StateList_tbl_BindDropDown_EmployeeViewModelId",
                        column: x => x.EmployeeViewModelId,
                        principalTable: "tbl_BindDropDown",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateList_EmployeeViewModelId",
                table: "StateList",
                column: "EmployeeViewModelId");
        }
    }
}
