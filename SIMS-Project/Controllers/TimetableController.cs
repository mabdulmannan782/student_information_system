using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class TimetableController : BaseController<Timetable>
    {
        public TimetableController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Timetable timetable) => await CreateBaseAsync(timetable);
        public async Task<IActionResult> Edit(int id, Timetable timetable) => await EditBaseAsync(id, timetable);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
