using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Range(0,2000)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime Orderdate { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Category { get; set; }
        [Range(0,15)]
        public string Shelf { get; set; }
        public int Count { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(40)]
        public string Description { get; set; }

      
    }
}
