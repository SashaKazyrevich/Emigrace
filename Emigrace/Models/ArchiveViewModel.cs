using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class ArchiveViewModel 
    {
       
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public string Country { get; set; }

        public string Phone { get; set; }

        public string WebPages { get; set; }

        public List<ArchivalFondViewModel> Fonds { get; set; } = new List<ArchivalFondViewModel>();
        


    }
}