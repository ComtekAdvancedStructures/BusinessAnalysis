using System;

namespace BusinessAnalysis.Model
{
    /// <summary>
    /// An influencing factor that is believed to be true but has not been confirmed to be accurate, or that could be true now but may not be in the future
    /// </summary>
    public class Assumption
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

    public class NullAssumption : Assumption
    {
        public NullAssumption() { Id = -1; }
    }
}