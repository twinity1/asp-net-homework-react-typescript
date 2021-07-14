using Microsoft.EntityFrameworkCore.Migrations;

namespace AspHomework2.Migrations
{
    public partial class JobApplicationDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Accepted",
                keyValue: null,
                column: "Accepted", 
                value: false
            );
            
            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                table: "JobApplications",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "JobApplications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "JobApplications");

            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                table: "JobApplications",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
