using FinalProjectDraft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectDraft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ProjectManger> ProjectManger { get; set; }
        public DbSet<TeamLeader> TeamLeaders { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectDeveloper> ProjectDevelopers { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<SprintTask> SprintTasks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<ReportStatus> ReportStatuses { get; set; }





        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProjectDeveloper>().HasKey(x => new { x.ProjectId, x.DeveloperId });
        }
    }
}
