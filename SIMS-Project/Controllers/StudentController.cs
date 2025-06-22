using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class StudentController : BaseController<Student>
    {
        public StudentController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Student student) => await CreateBaseAsync(student);
        public async Task<IActionResult> Edit(int id, Student student) => await EditBaseAsync(id, student);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
