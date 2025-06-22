using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class GradeController : BaseController<Grade>
    {
        public GradeController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Grade grade) => await CreateBaseAsync(grade);
        public async Task<IActionResult> Edit(int id, Grade grade) => await EditBaseAsync(id, grade);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
