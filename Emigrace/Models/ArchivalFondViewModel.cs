using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class ArchivalFondViewModel
    {
        [Required]
        public int Id { get; set; }

        public string FondNumber { get; set; }
        public string FondName { get; set; }
        public int ArchiveId { get; set; }
        public string TimeInterval { get; set; }
    }

}