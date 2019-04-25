using Microsoft.AspNetCore.Mvc;

namespace helloMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {

            // 赞助商支持 表格 数据
            ViewData["table_col_two"] = "名字";
            ViewData["table_col_three"] = "职位";

            ViewData["table_row_one_role"] = "网站制作及布署";
            ViewData["table_row_one_name"] = "叶落初冬";

            ViewData["table_row_two_role"] = "美工";
            ViewData["table_row_two_name"] = "蹄铁";

            return View();
        }

        public IActionResult SignUp() {
            ViewData["item1"] = "this is a item1, but is a test..";
            ViewData["item2"] = "this is a item2, but is a test..";
            ViewData["item3"] = "this is a item3, but is a test..";
            ViewData["item4"] = "this is a item4, but is a test..";
            
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
		
        public IActionResult test() {
            return View();
        }
    }
}
