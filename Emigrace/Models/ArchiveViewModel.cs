using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class ArchiveViewModel 
    {
       
        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string Country { get; set; }

        public string Phone { get; set; }

        public string WebPages { get; set; }

    }
}