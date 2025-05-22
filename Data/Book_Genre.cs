using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data
{
    [PrimaryKey(nameof(IdBook), nameof(IdGenre))]
    public class Book_Genre
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int IdBook {  get; set; }

        public Book Book   { get; set; }

        [ForeignKey("Genre")]
        public int IdGenre {  get; set; }

       public Genre Genre { get; set; }

    }
}
