using EduHomeBackEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<NoticeBoardLeft> NoticeBoardLefts { get; set; }
        public IEnumerable<NoticeBoardRight> NoticeBoardRights { get; set; }
        public WhyYouChooseUs WhyYouChooseUss { get; set; }
        public Testimonial Testimonials { get; set; }
    }
}
