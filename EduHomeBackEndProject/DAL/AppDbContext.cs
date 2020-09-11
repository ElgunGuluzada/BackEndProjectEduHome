using EduHomeBackEndProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoardLeft> noticeBoardLefts { get; set; }
        public DbSet<NoticeBoardRight> noticeBoardRights { get; set; }
        public DbSet<WhyYouChooseUs> whyYouChooseUss{ get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<SpeakerAndEvent> speakerAndEvents { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
