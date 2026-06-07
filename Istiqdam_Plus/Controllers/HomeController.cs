using Microsoft.AspNetCore.Mvc;
using Istiqdam_Plus.Models;
using System.Diagnostics;

namespace Istiqdam_Plus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // الصفحة الأولى التي تظهر عند فتح التطبيق
        public IActionResult Splash()
        {
            // سنضيف Layout = null في ملف Splash.cshtml لضمان ظهورها وحدها
            return View();
        }

        // لوحة التحكم الرئيسية (تظهر بعد صفحة الاستقبال)
        public IActionResult Index()
        {
            // هذه الصفحة تستخدم _Layout.cshtml تلقائياً
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//using System.Diagnostics;
//using Istiqdam_Plus.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace Istiqdam_Plus.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }

//        public IActionResult Splash()
//        {
//            return View(); // يعرض صفحة الاستقبال وحدها
//        }

//        public IActionResult Index()
//        {
//            return View(); // يعرض لوحة التحكم (التي تستخدم _Layout)
//        }


//        // يمكنك إبقاء هذه الدالة أو تغييرها
//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//} 