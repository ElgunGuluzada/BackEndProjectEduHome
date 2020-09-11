using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHomeBackEndProject.DAL;
using EduHomeBackEndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHomeBackEndProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM
            {
                Sliders = _db.Sliders,
                NoticeBoardLefts = _db.noticeBoardLefts,
                NoticeBoardRights = _db.noticeBoardRights,
                WhyYouChooseUss = _db.whyYouChooseUss.FirstOrDefault(),
                Testimonials=_db.Testimonials.FirstOrDefault()
            };
            return View(homeVm);
        }
    }
}
