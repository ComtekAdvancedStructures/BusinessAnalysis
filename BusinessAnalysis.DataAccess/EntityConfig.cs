using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using BusinessAnalysis.Model;

namespace BusinessAnalysis.DataAccess
{
    public class EntityConfig
    {
        public void ApplyConfig(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectConfig());
            modelBuilder.Ignore<NullProject>();

            modelBuilder.Configurations.Add(new AssumptionConfig());
            modelBuilder.Ignore<NullAssumption>();

            modelBuilder.Configurations.Add(new ConstraintConfig());
            modelBuilder.Ignore<NullConstraint>();

            modelBuilder.Configurations.Add(new ProjectNoteConfig());
            modelBuilder.Ignore<NullProjectNote>();

            modelBuilder.Configurations.Add(new RequirementConfig());
            modelBuilder.Ignore<NullRequirement>();

            modelBuilder.Configurations.Add(new RiskConfig());
            modelBuilder.Ignore<NullRisk>();

            modelBuilder.Configurations.Add(new ScopeItemConfig());
            modelBuilder.Ignore<NullScopeItem>();

            modelBuilder.Configurations.Add(new StakeholderConfig());
            modelBuilder.Ignore<NullStakeholder>();

            modelBuilder.Configurations.Add(new StakeholderTypeConfig());
            modelBuilder.Ignore<NullStakeholderType>();

            modelBuilder.Configurations.Add(new UseCaseConfig());
            modelBuilder.Ignore<NullUseCase>();

            modelBuilder.Configurations.Add(new UserStoryConfig());
            modelBuilder.Ignore<NullUserStory>();

            modelBuilder.Configurations.Add(new ActionConfig());
            modelBuilder.Ignore<NullAction>();
        }

        public class ProjectConfig : EntityTypeConfiguration<Project>
        {
            public ProjectConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);
                Ignore(x => x.StateName);

                Property(x => x.Name).IsRequired().HasMaxLength(64);
                Property(x => x.Description).IsRequired().HasMaxLength(256);
                Property(x => x.RequestedBy).IsRequired().HasMaxLength(64);
                Property(x => x.ProblemStatement).IsRequired().HasMaxLength(256);
                Property(x => x.VisionStatement).IsRequired().HasMaxLength(256);
                Property(x => x.State).IsRequired();

                Property(x => x.Analyst).IsOptional().HasMaxLength(64);
                Property(x => x.SponserName).IsOptional().HasMaxLength(64);

                HasMany(x => x.Notes).WithRequired(x => x.Project);
                HasMany(x => x.ScopeItems).WithRequired(x => x.Project);
                HasMany(x => x.Assumptions).WithRequired(x => x.Project);
                HasMany(x => x.Constraints).WithRequired(x => x.Project);
                HasMany(x => x.UseCases).WithRequired(x => x.Project);
                HasMany(x => x.UserStories).WithRequired(x => x.Project);
                HasMany(x => x.Risks).WithRequired(x => x.Project);

                HasMany(x => x.Stakeholders).WithMany(x => x.Projects);
            }
        }

        public class AssumptionConfig : EntityTypeConfiguration<Assumption>
        {
            public AssumptionConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Description).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.Assumptions);
            }
        }

        public class ConstraintConfig : EntityTypeConfiguration<Constraint>
        {
            public ConstraintConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Description).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.Constraints);

            }
        }

        public class ProjectNoteConfig : EntityTypeConfiguration<ProjectNote>
        {
            public ProjectNoteConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Text).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.Notes);

            }
        }

        public class RequirementConfig : EntityTypeConfiguration<Requirement>
        {
            public RequirementConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Description).IsRequired();
                Property(x => x.Type).IsRequired();

                Property(x => x.RequirementSatisfiedAuthorisedBy).IsOptional().HasMaxLength(64);
                Property(x => x.DateRequirementSatisfied).IsOptional();

                HasRequired(x => x.Project).WithMany(x => x.Requirements);
                HasMany(x => x.UserStories).WithRequired(x => x.Requirement);
            }
        }

        public class RiskConfig : EntityTypeConfiguration<Risk>
        {
            public RiskConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Description).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.Risks);

            }
        }

        public class ScopeItemConfig : EntityTypeConfiguration<ScopeItem>
        {
            public ScopeItemConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Description).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.ScopeItems);
            }
        }

        public class StakeholderConfig : EntityTypeConfiguration<Stakeholder>
        {
            public StakeholderConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Name).IsRequired();
                Property(x => x.Description).IsRequired();

                HasMany(x => x.Projects).WithMany(x => x.Stakeholders);
                HasMany(x => x.UserStories).WithRequired(x => x.Stakeholder);
            }
        }

        public class StakeholderTypeConfig : EntityTypeConfiguration<StakeholderType>
        {
            public StakeholderTypeConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Name).IsRequired();
                Property(x => x.Description).IsRequired();
            }
        }

        public class UseCaseConfig : EntityTypeConfiguration<UseCase>
        {
            public UseCaseConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Actor).IsRequired();
                Property(x => x.Notes).IsRequired();

                HasRequired(x => x.Project).WithMany(x => x.UseCases);
                HasRequired(x => x.Action).WithMany(x => x.UseCases);
            }
        }

        public class UserStoryConfig : EntityTypeConfiguration<UserStory>
        {
            public UserStoryConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Property(x => x.Notes).IsOptional().HasMaxLength(256);

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                HasRequired(x => x.Action).WithMany(x => x.UserStories);
                HasRequired(x => x.Requirement).WithMany(x => x.UserStories);
                HasRequired(x => x.Stakeholder).WithMany(x => x.UserStories);
                HasRequired(x => x.Project).WithMany(x => x.UserStories);
            }
        }

        public class ActionConfig : EntityTypeConfiguration<Action>
        {
            public ActionConfig()
            {
                HasKey(x => x.Id);
                Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(x => x.CreatedBy).IsRequired();
                Property(x => x.LastModifiedBy).IsRequired();
                Property(x => x.DateCreated).IsRequired();
                Property(x => x.DateLastModified).IsRequired();

                Ignore(x => x.DateCreatedString);
                Ignore(x => x.DateLastModifiedString);

                Property(x => x.Name).IsRequired().HasMaxLength(64);
                Property(x => x.Description).IsOptional().HasMaxLength(256);

                HasMany(x => x.UserStories).WithRequired(x => x.Action);
                HasMany(x => x.UseCases).WithRequired(x => x.Action);

                HasRequired(x => x.Project).WithMany(x => x.Actions);
            }
        }
    }
}