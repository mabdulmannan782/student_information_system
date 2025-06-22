using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class UserRoleController : BaseController<UserRole>
    {
        public UserRoleController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(UserRole userRole) => await CreateBaseAsync(userRole);
        public async Task<IActionResult> Edit(int id, UserRole userRole) => await EditBaseAsync(id, userRole);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
