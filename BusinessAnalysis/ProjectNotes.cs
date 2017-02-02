using System;

namespace BusinessAnalysis.Model
{
    public class ProjectNote
    {
        public int Id { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public string DateCreatedString => DateCreated.ToString("MMMM dd, yyyy");
        public string DateLastModifiedString => DateCreated.ToString("MMMM dd, yyyy");

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string Text { get; set; }
    }

    public class NullProjectNote : ProjectNote
    {
        public NullProjectNote() { Id = -1; }
    }
}