using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author {  get; set; }

        [Required]
        public double Price {  get; set; }

        [ForeignKey("Publisher")]

        public int PublisherId {  get; set; }

        public Publisher Publisher { get; set; }


        [ForeignKey("Status")]
        public int StatusId {  get; set; }

        public Status Status { get; set; }

    }
}
