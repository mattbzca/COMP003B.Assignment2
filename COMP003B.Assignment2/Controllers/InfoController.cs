using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
