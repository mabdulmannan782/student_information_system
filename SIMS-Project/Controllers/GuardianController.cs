using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class GuardianController : BaseController<Guardian>
    {
        public GuardianController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Guardian guardian) => await CreateBaseAsync(guardian);
        public async Task<IActionResult> Edit(int id, Guardian guardian) => await EditBaseAsync(id, guardian);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
