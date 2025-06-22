using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class AssignmentController : BaseController<Assignment>
    {
        public AssignmentController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Assignment assignment) => await CreateBaseAsync(assignment);
        public async Task<IActionResult> Edit(int id, Assignment assignment) => await EditBaseAsync(id, assignment);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
