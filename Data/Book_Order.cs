using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [PrimaryKey(nameof(IdBook), nameof(IdOrder), nameof(IdWorker))]
    public class Book_Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int IdBook {  get; set; }
        public Book Book { get; set; }

        [ForeignKey("Order")]
        public int IdOrder {  get; set; }

        public Order Order { get; set; }

        [ForeignKey("Worker")]
        public int IdWorker {  get; set; }
        public Worker Worker { get; set; }

        [Required]
        public int NumberOfBooks { get; set; }

    }
}
