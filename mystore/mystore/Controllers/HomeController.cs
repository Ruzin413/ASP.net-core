using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mystore.Models;

namespace mystore.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDBContext employee;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(EmployeeDBContext employee)
        {
            this.employee = employee;
        }
        //[Route("[H]/[action]")]
        public IActionResult Index()
        {
            var empdata = employee.employees1.ToList();
            return View(empdata);
            //return View();
        }
        //[HttpPost]
        //public string Index(Employee e)
        //{

        //    if (ModelState.IsValid)

        //    {
        //        ModelState.Clear();
        //        return "Name" + e.FormName + "Age" + e.FormAge + "Gender" + e.Gender + "Starus" + e.Married;
        //    }
        //    else
        //    {
        //        return "Validation failed";
        //    }
        //}
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                 await employee.employees1.AddAsync(emp);
                 await employee.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(emp);
        }
        public async Task<IActionResult> Details(int id)
        {
            var det = await employee.employees1.FirstOrDefaultAsync(x => x.ID == id);
            return View(det);
        }
        public async Task<IActionResult> Edit(int id, Employee emmp)
        {
            if (id != emmp.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                employee.employees1.Update(emmp);
                await employee.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(emmp);
        }
        public async Task<IActionResult> Delete(int id, Employee emp){
            var del = await employee.employees1.FirstOrDefaultAsync(x => x.ID == id);
            if (id != emp.ID)
            {
                return NotFound();
            }
            if (del == null)
            {
                return NotFound();
            }
            return View(del);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var del = await employee.employees1.FindAsync(id);
            if (del != null) { 
                employee.employees1.Remove(del);
            }
            await employee.SaveChangesAsync();
            TempData["Sucess"] = "Data deleted";
            return RedirectToAction("Index");
        } 
        //[Route("[h]/[Privacy1]")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Detail/{id}")]
        public int Detail(int id)
        {
            return id;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
