using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Models
{
    public class Speaker
    {
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string Profession { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
        public virtual ICollection<SpeakerAndEvent> SpeakerAndEvents { get; set; }

    }
}
