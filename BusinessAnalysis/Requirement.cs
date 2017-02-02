using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusinessAnalysis.Model
{
    public class Requirement
    {
        public int Id { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public string DateCreatedString => DateCreated.ToString("MMMM dd, yyyy");
        public string DateLastModifiedString => DateCreated.ToString("MMMM dd, yyyy");

        public Project Project { get; set; }
        public int ProjectId { get; set; }

        public RequirementType Type { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Has the requirement been satisfied in the solution?
        /// </summary>
        [DisplayName("Requirment Satisfied in Solution")]
        public bool RequirementSatisfied { get; set; }
        /// <summary>
        /// User who signed off on the requirement as being satisfied
        /// </summary>
        [DisplayName("Requirment Signed-off By")]
        public string RequirementSatisfiedAuthorisedBy { get; set; }
        [DisplayName("Date Requirment was marked as Satisfied")]
        public DateTime? DateRequirementSatisfied { get; set; }

        [DisplayName("Requirement is Active")]
        public bool Active { get; set; }

        /// <summary>
        /// In point form, a small, concise statement of functionality or quality needed to deliver value to a specific stakeholder. 
        /// List each stake holder, then one or more statements describing the functionality that he or she requires. 
        /// </summary>
        public List<UserStory> UserStories { get; set; }

    }

    public class NullRequirement : Requirement
    {
        public NullRequirement() { Id = -1; }
    }

    public enum RequirementType
    {
        /// <summary>
        /// A list of goals, objectives and outcomes that describe why a change has been initiated and how success will be assessed. 
        /// These are high-level requirements, no need to go into detail
        /// </summary>
        Business,
        /// <summary>
        /// A description of the needs of a particular stakeholder or class of stakeholders that must be met in order to achieve the business requirements. 
        /// They may serve as a bridge between business requirements and the various categories of solution requirements
        /// </summary>
        Stakeholder,
        /// <summary>
        /// A detailed list of all the functionality that is to be incorporated into the solution. 
        /// Describe each individual piece of functionality that will be in the solution. 
        /// Be as specific as possible. This list of functionality will be driving the features implemented in the solution.
        /// </summary>
        Solution,
        /// <summary>
        /// What the solution must do
        /// </summary>
        Functional,
        /// <summary>
        /// A type of requirement that describes the performance or quality attributes a solution must meet. 
        /// Non-functional requirements are usually measurable and act as constraints on the design of a solution as a whole 
        /// </summary>
        NonFunctional,
        /// <summary>
        /// A requirement that describes the capabilities the solution must have 
        /// and the conditions the solution must meet to facilitate transition from the current state to the future state, 
        /// but which are not needed once the change is complete. 
        /// They are differentiated from other requirements types because they are of a temporary nature
        /// </summary>
        Transition
    }
}