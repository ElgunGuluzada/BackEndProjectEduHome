using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class NoticeBoardRight
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
      
        [Required]
        [MaxLength(500)]
        public string Discription { get; set; }
    }
}
