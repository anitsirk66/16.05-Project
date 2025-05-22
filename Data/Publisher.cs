using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Publisher
    {
        [Key]
        public int IdPub {  get; set; }

        [Required]
        [MaxLength(50)]
        public string Name {  get; set; }

        [Required]
        [Range(1,5)]
        public int Rating {  get; set; }

    }
}
