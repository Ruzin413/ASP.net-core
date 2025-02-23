using Microsoft.AspNetCore.Mvc;

namespace mystore.Controllers
{
    public class Mypage : Controller
    {
        public IActionResult home()
        {
            return View();
        }
    }
}
