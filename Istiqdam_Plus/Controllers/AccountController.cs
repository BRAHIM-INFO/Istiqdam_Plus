using Microsoft.AspNetCore.Mvc;

namespace Istiqdam_Plus.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View(); // يعرض صفحة تسجيل الدخول
        }
    }
}
