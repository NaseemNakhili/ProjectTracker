using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectDraft.Data.Migrations
{
    public partial class statues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusId",
                table: "SprintTasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusId",
                table: "Sprints",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReportStatusId",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatusId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjectStatuses",
                columns: table => new
                {
                    ProjectStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatuses", x => x.ProjectStatusId);
                });

            migrationBuilder.CreateTable(
                name: "ReportStatuses",
                columns: table => new
                {
                    ReportStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportStatuses", x => x.ReportStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SprintTasks_ProjectStatusId",
                table: "SprintTasks",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_ProjectStatusId",
                table: "Sprints",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportStatusId",
                table: "Reports",
                column: "ReportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectStatuses_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId",
                principalTable: "ProjectStatuses",
                principalColumn: "ProjectStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportStatuses_ReportStatusId",
                table: "Reports",
                column: "ReportStatusId",
                principalTable: "ReportStatuses",
                principalColumn: "ReportStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_ProjectStatuses_ProjectStatusId",
                table: "Sprints",
                column: "ProjectStatusId",
                principalTable: "ProjectStatuses",
                principalColumn: "ProjectStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SprintTasks_ProjectStatuses_ProjectStatusId",
                table: "SprintTasks",
                column: "ProjectStatusId",
                principalTable: "ProjectStatuses",
                principalColumn: "ProjectStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectStatuses_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportStatuses_ReportStatusId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_ProjectStatuses_ProjectStatusId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_SprintTasks_ProjectStatuses_ProjectStatusId",
                table: "SprintTasks");

            migrationBuilder.DropTable(
                name: "ProjectStatuses");

            migrationBuilder.DropTable(
                name: "ReportStatuses");

            migrationBuilder.DropIndex(
                name: "IX_SprintTasks_ProjectStatusId",
                table: "SprintTasks");

            migrationBuilder.DropIndex(
                name: "IX_Sprints_ProjectStatusId",
                table: "Sprints");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportStatusId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "SprintTasks");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "ReportStatusId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ProjectStatusId",
                table: "Projects");
        }
    }
}
