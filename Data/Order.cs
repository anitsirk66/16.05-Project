using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        [Key]
        public int OrderId {  get; set; }

        [Required] 
        public DateTime Date { get; set; }

        [Required]
        public string TrackingNumber{get;set;}

        [Required]
        [MaxLength(100)]   
        public string Address {  get; set; }

    }
}
