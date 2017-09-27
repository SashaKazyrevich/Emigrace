using System.ComponentModel.DataAnnotations;


namespace Emigrace.Models
{
    public class ArchivalDocumentViewModel
    {
        [Required]
        public int Id { get; private set; }

        [Required]
        public string FondName { get; private set; }

        [Required]
        public string TimeInterval { get; private set; }

        public string Language { get; private set; }

    }
}