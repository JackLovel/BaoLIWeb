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
            ViewData["qqGroup"] = "2123131204123";

            return View();
        }

        public IActionResult BuyTicket() {
            return View();
        }

        public IActionResult KnowMore() {
            return View();
        }

        public IActionResult ProductInformation() {
            return View();
        }
		
        public IActionResult Slide1Page() {
            return View();
        }
        public IActionResult Slide2Page() {
            return View();
        }

        public IActionResult Slide3Page() {
            return View();
        }
    }
}
