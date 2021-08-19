using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectDraft.Data.Migrations
{
    public partial class mainEntites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ProjectMangerId = table.Column<string>(nullable: true),
                    TeamLeaderId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_ProjectMangerId",
                        column: x => x.ProjectMangerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_TeamLeaderId",
                        column: x => x.TeamLeaderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDevelopers",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    DeveloperId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDevelopers", x => new { x.ProjectId, x.DeveloperId });
                    table.ForeignKey(
                        name: "FK_ProjectDevelopers_AspNetUsers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectDevelopers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    SprintId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SprintName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndtDate = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.SprintId);
                    table.ForeignKey(
                        name: "FK_Sprints_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SprintTasks",
                columns: table => new
                {
                    SprintTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SprintTaskTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SprintId = table.Column<int>(nullable: false),
                    DeveloperId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprintTasks", x => x.SprintTaskId);
                    table.ForeignKey(
                        name: "FK_SprintTasks_AspNetUsers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SprintTasks_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTitel = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SprintTaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_Reports_SprintTasks_SprintTaskId",
                        column: x => x.SprintTaskId,
                        principalTable: "SprintTasks",
                        principalColumn: "SprintTaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDevelopers_DeveloperId",
                table: "ProjectDevelopers",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectMangerId",
                table: "Projects",
                column: "ProjectMangerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamLeaderId",
                table: "Projects",
                column: "TeamLeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_SprintTaskId",
                table: "Reports",
                column: "SprintTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_ProjectId",
                table: "Sprints",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SprintTasks_DeveloperId",
                table: "SprintTasks",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_SprintTasks_SprintId",
                table: "SprintTasks",
                column: "SprintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectDevelopers");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "SprintTasks");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
