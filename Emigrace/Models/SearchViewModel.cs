
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Emigrace.Models
{
    public class SearchViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Place { get; set; }

        public long SourceId { get; set; }

    }
}