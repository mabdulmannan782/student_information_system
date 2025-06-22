using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class ClassController : BaseController<Class>
    {
        public ClassController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Class classEntity) => await CreateBaseAsync(classEntity);
        public async Task<IActionResult> Edit(int id, Class classEntity) => await EditBaseAsync(id, classEntity);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
