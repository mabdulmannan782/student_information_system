using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class TeacherController : BaseController<Teacher>
    {
        public TeacherController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Teacher teacher) => await CreateBaseAsync(teacher);
        public async Task<IActionResult> Edit(int id, Teacher teacher) => await EditBaseAsync(id, teacher);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
