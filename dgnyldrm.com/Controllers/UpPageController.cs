using Microsoft.AspNetCore.Mvc;

namespace dgnyldrm.com.Controllers
{
    public class UpPageController : Controller
    {
        public IActionResult Iletisim()
        {
            return View();
        }


        public IActionResult Hakkimda()
        {
            return View();
        }
    }
}
