using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class Testimonial
    {
        public int id { get; set; }
        [Required]
        public string backGroundImage { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Job { get; set; }
        [Required]
        [MaxLength(50)]
        public string nameOfLesson { get; set; }
    }
}
