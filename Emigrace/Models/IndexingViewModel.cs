using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class IndexingViewModel
    {
        [Required]
        public long SourceId { get; set; }

        [Display(Name = "NameLatin")]
        public string NameLatin { get; set; }

        [Required]
        [Display(Name = "FamilyNameLatin")]
        public string FamilyNameLatin { get; set; }

        [Display(Name = "NameCyrillic")]
        public string NameCyrillic { get; set; }

        [Required]
        [Display(Name = "FamilyNameCyrillic")]
        public string FamilyNameCyrillic { get; set; }

       
    }

}