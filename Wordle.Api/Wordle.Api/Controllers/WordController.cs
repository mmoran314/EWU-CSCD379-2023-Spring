using Microsoft.AspNetCore.Mvc;

namespace Wordle.Api.Controllers
{
    public class WordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
