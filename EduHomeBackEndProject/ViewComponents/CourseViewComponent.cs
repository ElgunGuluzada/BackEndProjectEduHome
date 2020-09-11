﻿using EduHomeBackEndProject.DAL;
using EduHomeBackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public CourseViewComponent(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            IEnumerable<Course> course = _db.Courses.Take(count);
            return View(await Task.FromResult(course));
        }

    }
}
