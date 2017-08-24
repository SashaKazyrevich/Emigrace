using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class IndexingViewModel
    {
        [Required]
        public long SourceId { get; set; }

        [Display(Name = "Name_Latin")]
        public string Name_Latin { get; set; }

        [Required]
        [Display(Name = "FamilyName_Latin")]
        public string FamilyName_Latin { get; set; }

        [Display(Name = "Name_Cyrillic")]
        public string Name_Cyrillic { get; set; }

        [Required]
        [Display(Name = "FamilyName_Cyrillic")]
        public string FamilyName_Cyrillic { get; set; }

       
    }

}