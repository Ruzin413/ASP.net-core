using Microsoft.AspNetCore.Mvc;

namespace mystore.Controllers
{
    public class Mypage : Controller
    {
        public IActionResult home()
        {
            
            return View();
        }
        [Route("privacy/{id1:int?}")]
        public IActionResult Privacy(int id1)
        {
            List<object> arr = new List<object> { 1, 34, "34", "sdjyhf", "fsd" };
            ViewData["data1"] = "hello";
            //ViewData["data2"] = id1;
            //ViewData["data3"] = arr;
            ViewBag.data12 = arr;
            return View();
        }

    }
}
