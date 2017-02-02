using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BusinessAnalysis.Model;

namespace BusinessAnalysis.DataAccess
{
    public class BusinessAnalysisDbContext : DbContext, IBusinessAnalysisDbContext
    {
        private const string AppName = "RepairPackage";

        public BusinessAnalysisDbContext() : base($"name={AppName}ConnectionString")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Assumption> Assumptions { get; set; }
        public DbSet<Constraint> Constraints { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<ScopeItem> ScopeItems { get; set; }
        public DbSet<Stakeholder> StockStakeholders { get; set; }
        public DbSet<StakeholderType> StakeholderTypes { get; set; }
        public DbSet<UseCase> UseCases { get; set; }
        public DbSet<UserStory> UserStories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<BusinessAnalysisDbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            var entityConfig = new EntityConfig();
            entityConfig.ApplyConfig(modelBuilder);
        }
    }
}