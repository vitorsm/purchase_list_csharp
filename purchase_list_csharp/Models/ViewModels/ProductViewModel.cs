using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace purchase_list_csharp.Models.ViewModels
{
    public class ProductViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? CreatedById { get; set; }
        public String CreatedByName { get; set; }
    }
}
