using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Genre
    {
        [Key]
		public int IdGenre{get;set;}

		[Required]
		[MaxLength(30)]
		public string GenreName {  get; set; }

	}
}
