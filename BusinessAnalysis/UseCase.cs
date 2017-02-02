using System;

namespace BusinessAnalysis.Model
{
    public class UseCase
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

        public string Actor { get; set; }
        public Action Action { get; set; }

        public string Notes { get; set; }
    }

    public class NullUseCase : UseCase
    {
        public NullUseCase() { Id = -1; }
    }
}