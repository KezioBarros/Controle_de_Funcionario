using Microsoft.AspNetCore.Mvc;

namespace SeleWebMvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
