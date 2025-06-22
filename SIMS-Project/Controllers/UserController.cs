using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class UserController : BaseController<User>
    {
        public UserController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(User user) => await CreateBaseAsync(user);
        public async Task<IActionResult> Edit(int id, User user) => await EditBaseAsync(id, user);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
