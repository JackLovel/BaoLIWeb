using Microsoft.AspNetCore.Mvc;

namespace helloMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            ViewBag.tao_bao = "https://item.taobao.com/item.htm?spm=a230r.1.14.84.3cea526aNwFCsz&id=588644610500&ns=1&abbucket=12#detail";

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
            ViewBag.nyato = @"https://www.nyato.com/manzhan/15275/?section=1#nav-content&tdsourcetag=s_pcqq_aiomsg";
            ViewBag.mo_dian= @"https://zhongchou.modian.com/item/59601.html";
            ViewBag.tao_bao = @"https://item.taobao.com/item.htm?spm=a230r.1.14.84.3cea526aNwFCsz&id=588644610500&ns=1&abbucket=12#detail";
           
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
            ViewBag.nyato = "https://www.nyato.com/manzhan/15275/?section=1#nav-content&tdsourcetag=s_pcqq_aiomsg";
            ViewBag.mo_dian= "https://zhongchou.modian.com/item/59601.html";
            ViewBag.tao_bao = "https://item.taobao.com/item.htm?spm=a230r.1.14.84.3cea526aNwFCsz&id=588644610500&ns=1&abbucket=12#detail";
            
            return View("BuyTicket");
        }
    }
}
