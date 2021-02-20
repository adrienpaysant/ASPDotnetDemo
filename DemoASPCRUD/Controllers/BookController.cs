using Microsoft.AspNetCore.Mvc;

namespace DemoASPCRUD.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
