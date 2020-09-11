using EduHomeBackEndProject.DAL;
using EduHomeBackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.ViewComponents
{
    public class EventViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public EventViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            IEnumerable<Event> events = _db.Events.Take(count);
            return View(await Task.FromResult(events));
        }

    }
}
