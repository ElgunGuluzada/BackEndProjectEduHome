using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class NoticeBoardLeft
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        [MaxLength(200)]
        public string Discription { get; set; }
    }
}
