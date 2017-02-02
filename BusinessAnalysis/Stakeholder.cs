using System;
using System.Collections.Generic;

namespace BusinessAnalysis.Model
{
    public class Stakeholder
    {
        public int Id { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public string DateCreatedString => DateCreated.ToString("MMMM dd, yyyy");
        public string DateLastModifiedString => DateCreated.ToString("MMMM dd, yyyy");

        public List<Project> Projects { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public StakeholderType Type { get; set; }

        public List<UserStory> UserStories { get; set; }
        public List<Action> Actions { get; set; }
    }

    public class NullStakeholder : Stakeholder
    {
        public NullStakeholder() { Id = -1; }
    }
}