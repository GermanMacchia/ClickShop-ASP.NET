using Microsoft.AspNetCore.Mvc;

namespace ClickShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
