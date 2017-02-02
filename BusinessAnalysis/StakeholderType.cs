using System;

namespace BusinessAnalysis.Model
{
    public class StakeholderType
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
    }
    public class NullStakeholderType : StakeholderType
    {
        public NullStakeholderType() { Id = -1; }
    }
}