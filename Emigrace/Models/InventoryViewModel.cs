using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emigrace.Models
{
    public class InventoryViewModel
    {
        [Required]
        public int Id { get; set; }

        public int InventoryNumber { get; set; }
        
    }

}