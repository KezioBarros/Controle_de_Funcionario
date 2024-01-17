using Microsoft.AspNetCore.Mvc;

namespace SeleWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
