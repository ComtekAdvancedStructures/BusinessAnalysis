using System.Data.Entity;
using BusinessAnalysis.Model;

namespace BusinessAnalysis.DataAccess
{
    public interface IBusinessAnalysisDbContext
    {
        DbSet<Project> Projects { get; set; }
        DbSet<Assumption> Assumptions { get; set; }
        DbSet<Constraint> Constraints { get; set; }
        DbSet<Requirement> Requirements { get; set; }
        DbSet<Risk> Risks { get; set; }
        DbSet<ScopeItem> ScopeItems { get; set; }
        DbSet<Stakeholder> StockStakeholders { get; set; }
        DbSet<StakeholderType> StakeholderTypes { get; set; }
        DbSet<UseCase> UseCases { get; set; }
        DbSet<UserStory> UserStories { get; set; }
    }
}