using Microsoft.AspNetCore.Mvc;
using SIMS_Project.Data;
using SIMS_Project.Models;

namespace SIMS_Project.Controllers
{
    public class ExamController : BaseController<Exam>
    {
        public ExamController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index() => await IndexBaseAsync();
        public async Task<IActionResult> Details(int id) => await DetailsBaseAsync(id);
        public async Task<IActionResult> Create(Exam exam) => await CreateBaseAsync(exam);
        public async Task<IActionResult> Edit(int id, Exam exam) => await EditBaseAsync(id, exam);
        public async Task<IActionResult> Delete(int id) => await DeleteBaseAsync(id);
    }
}
