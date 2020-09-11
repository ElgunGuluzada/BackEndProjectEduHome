using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class Event
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string FinishTime { get; set; }
        [Required]
        [MaxLength(100)]
        public string Place { get; set; }
        public bool isDeleted { get; set; }
        public virtual ICollection<SpeakerAndEvent> SpeakerAndEvents { get; set; }
    }
}
