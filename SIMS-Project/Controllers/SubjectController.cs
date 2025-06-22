using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class SubjectController : BaseController<Subject>
    {
        public SubjectController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Subject subject) => await CreateBaseAsync(subject);
        public async Task<IActionResult> Edit(int id, Subject subject) => await EditBaseAsync(id, subject);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
