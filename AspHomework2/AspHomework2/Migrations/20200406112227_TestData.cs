using Microsoft.EntityFrameworkCore.Migrations;

namespace AspHomework2.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPositions_Branches_BranchId",
                table: "JobPositions");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "JobPositions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Praha" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "Brno" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Ostrava" });

            migrationBuilder.InsertData(
                table: "JobPositions",
                columns: new[] { "Id", "BranchId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Angular junior" },
                    { 2, 1, "PHP senior" },
                    { 3, 2, "Ruby medior" },
                    { 4, 2, "HR" },
                    { 5, 3, "Java senior" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositions_Branches_BranchId",
                table: "JobPositions",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPositions_Branches_BranchId",
                table: "JobPositions");

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPositions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "JobPositions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_JobPositions_Branches_BranchId",
                table: "JobPositions",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
