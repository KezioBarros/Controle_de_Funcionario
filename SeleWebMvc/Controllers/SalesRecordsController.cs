using Microsoft.AspNetCore.Mvc;

namespace SeleWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordsController
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
