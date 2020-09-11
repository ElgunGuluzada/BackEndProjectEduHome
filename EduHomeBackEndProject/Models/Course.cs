using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string classDuration { get; set; }
        [Required]
        public string skillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int studentCapacity { get; set; }
        [Required]
        public string Assetsments { get; set; }
        [Required]
        public double coursePrice { get; set; }
        [Required]
        public string startCourse { get; set; }
        public int categoriesId { get; set; }
        public Categories Categories { get; set; }
    }

}
