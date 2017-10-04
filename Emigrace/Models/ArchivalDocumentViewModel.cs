using System.ComponentModel.DataAnnotations;


namespace Emigrace.Models
{
    public class ArchivalDocumentViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FondName { get; set; }

        public string FondNumber { get; set; }

        [Required]
        public string TimeInterval { get; set; }

        public string Language { get; set; }

    }
}