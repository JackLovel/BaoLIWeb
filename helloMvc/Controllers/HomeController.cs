using Microsoft.AspNetCore.Mvc;

namespace helloMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult SignUp() {
            return View();
        }

        public IActionResult ContactUs() {
            return View();
        }

        public IActionResult BuyTicket() {
            return View();
        }

        public IActionResult KnowMore() {
            return View();
        }
    }
}
