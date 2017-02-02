using System;
using System.Collections.Generic;

namespace BusinessAnalysis.Model
{
    public class Project
    {
        public int Id { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public string DateCreatedString => DateCreated.ToString("MMMM dd, yyyy");
        public string DateLastModifiedString => DateCreated.ToString("MMMM dd, yyyy");

        public string Name { get; set; }
        public string Description { get; set; }

        public string SponserName { get; set; }
        public string RequestedBy { get; set; }
        public string Analyst { get; set; }

        public AnalysisState State { get; set; }
        public string StateName => State.ToString();

        /// <summary>
        /// Describe the current state and outline the problem or opportunity that will be addressed and the parts of the organization that are directly impacted
        /// </summary>
        public string ProblemStatement { get; set; }
        /// <summary>
        /// A brief statement or paragraph that describes the goals of the solution and how it supports the strategy of the organization
        /// Used to help define and drive the solution scope
        /// </summary>
        public string VisionStatement { get; set; }
        /// <summary>
        /// A list of items that are in scope, or specifically out of scope
        /// </summary>
        public List<ScopeItem> ScopeItems { get; set; }

        /// <summary>
        /// An influencing factor that is believed to be true but has not been confirmed to be accurate, 
        /// or that could be true now but may not be in the future
        /// </summary>
        public List<Assumption> Assumptions { get; set; }
        /// <summary>
        /// An influencing factor that cannot be changed, and that places a limit or restriction on a possible solution or solution option
        /// </summary>
        public List<Constraint> Constraints { get; set; }

        public List<Stakeholder> Stakeholders { get; set; }
        public List<UseCase> UseCases { get; set; }

        /// <summary>
        /// A list of needs that the solution must meet in order for the project to be completed. 
        /// This list may be constrained by time, budget, or resource. 
        /// For example, it is acceptable to meet all of the requirements possible by a given date, then close the project
        /// </summary>
        public List<Requirement> Requirements { get; set; }
        /// <summary>
        /// In point form, a small, concise statement of functionality or quality needed to deliver value to a specific stakeholder. 
        /// List each stake holder, then one or more statements describing the functionality that he or she requires. 
        /// </summary>
        public List<UserStory> UserStories { get; set; }
        /// <summary>
        /// The effect of uncertainty on the value of a change, a solution, or the enterprise
        /// </summary>
        public List<Risk> Risks { get; set; }

        public List<Action> Actions { get; set; }

        public List<ProjectNote> Notes { get; set; }
    }

    public class NullProject : Project
    {
        public NullProject() { Id = -1; }
    }

    public enum AnalysisState
    {
        Initiation,
        Discovery,
        ReadyForApproval,
        Approved,
        WorkInProgress,
        Completed
    }
}