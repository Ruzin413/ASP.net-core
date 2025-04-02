using Microsoft.AspNetCore.Mvc;
using mystore.Models;
using mystore.Repository;
using System.Diagnostics;

namespace mystore.Controllers
{
    public class Mypage : Controller
    {
        private readonly ILogger<Mypage> _logger;
        private readonly StudentRepo _studentrepo = null;

        public Mypage(ILogger<Mypage> logger)
        {
            _logger = logger;
            _studentrepo = new StudentRepo();

        }
        public List<Student> getstd1()
        {
            return _studentrepo.student();
        }
        public List<Student> getstdbyid(int id)
        {
            return _studentrepo.getById(id);
        }
        [Route("")]
        public IActionResult home()
        {
            var studentlist = new List<Student>() {
                new Student { rollno = 1 , Name ="djs" ,subject ="science"},
                new Student { rollno = 12 , Name ="djs" ,subject ="sc54ience"},
                new Student { rollno = 13 , Name ="dj23s" ,subject ="s213cience"}
            };
            //StudentRepo s1 = new StudentRepo();
            //var datas = s1.getById(1);
            //ViewBag.data = datas;
            ViewData["num"] = 123;
            ViewData["mystudents"] = studentlist;
            TempData["data15"] = "this is from home";
            return View(studentlist);
        }
        [HttpPost]
        public string home(Employee e)
        {
            return "Name" + e.FormName + "Age" + e.FormAge + "Gender" + e.Gender + "Starus" + e.Married;
        }

        [Route("privacy/{id1:int?}")]
        public IActionResult Privacy(int id1)
        {
            //List<object> arr = new List<object> { 1, 34, "34", "sdjyhf", "fsd" };
            //ViewData["data1"] = "hello";
            //ViewData["data2"] = id1;
            //ViewData["data3"] = arr;
            //ViewBag.data12 = arr;
            return View();
        }
      
        public IActionResult Form()
        {
            return View();
        }

    }
}
