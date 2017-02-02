using System;

namespace BusinessAnalysis.Model
{
    public class ScopeItem
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

        public string Description { get; set; }
        public bool InScope { get; set; }
        public ScopeCategory Category { get; set; }
    }

    public class NullScopeItem : ScopeItem
    {
        public NullScopeItem() { Id = -1; }
    }

    public enum ScopeCategory
    {
        Functionality,
        Users,
        Deliverables
    }
}