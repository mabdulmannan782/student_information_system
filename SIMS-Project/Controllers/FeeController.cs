using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class FeeController : BaseController<Fee>
    {
        public FeeController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Fee fee) => await CreateBaseAsync(fee);
        public async Task<IActionResult> Edit(int id, Fee fee) => await EditBaseAsync(id, fee);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
