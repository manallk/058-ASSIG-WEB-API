using System.ComponentModel.DataAnnotations;

namespace EverHourEats.Model
{
    public class Person
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public String name { get; set; }
        [Required]
        public String email { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        [StringLength(50)]
        public String adress { get; set; }
    }
}

