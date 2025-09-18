using ManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ManagementDbContext _context;

        public EmployeeController(ManagementDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var emp = _context.Employees
                .Include(e => e.Department).ToList();


            return View(emp);
        }
    }
}
