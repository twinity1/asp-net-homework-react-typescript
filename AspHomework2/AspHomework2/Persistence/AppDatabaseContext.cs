using ASPHomework.Persistence;
using AspHomework2.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspHomework2.Persistence
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
            
        }
    
        public DbSet<Branch> Branches { get; set; }
        
        public DbSet<JobPosition> JobPositions { get; set; }
        
        public DbSet<JobApplication> JobApplications { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new TestDataGenerator().Generate(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}