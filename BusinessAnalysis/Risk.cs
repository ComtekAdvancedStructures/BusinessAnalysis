using System;

namespace BusinessAnalysis.Model
{
    /// <summary>
    /// The effect of uncertainty on the value of a change, a solution, or the enterprise
    /// </summary>
    public class Risk
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
    }

    public class NullRisk : Risk
    {
        public NullRisk() { Id = -1; }
    }
}