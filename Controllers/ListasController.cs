using Microsoft.AspNetCore.Mvc;

namespace WebAppTest.Controllers
{
    public class ListasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
