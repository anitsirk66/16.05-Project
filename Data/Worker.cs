using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Data
{
    public class Worker
    {
        [Key]
		public int IdWorker { get; set; }

		[Required]
		[MaxLength(100)]
		public string FullName   { get; set; }

		[Required]
		[Range(500, 2500)]
		public double Salary {  get; set; }

		[Required]
		public int WorkExperience {  get; set; }

	}
}
