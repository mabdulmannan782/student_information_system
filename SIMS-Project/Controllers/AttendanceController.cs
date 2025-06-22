using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class AttendanceController : BaseController<Attendance>
    {
        public AttendanceController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Attendance attendance) => await CreateBaseAsync(attendance);
        public async Task<IActionResult> Edit(int id, Attendance attendance) => await EditBaseAsync(id, attendance);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
