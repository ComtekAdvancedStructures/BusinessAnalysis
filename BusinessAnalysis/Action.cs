using System;
using System.Collections.Generic;

namespace BusinessAnalysis.Model
{
    public class Action
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

        public string Name { get; set; }
        public string Description { get; set; }

        public List<UseCase> UseCases { get; set; }
        public List<UserStory> UserStories { get; set; }
        public List<Stakeholder> Stakeholders { get; set; }
    }

    public class NullAction : Action
    {
        public NullAction()
        {
            Id = -1;
        }
    }
}