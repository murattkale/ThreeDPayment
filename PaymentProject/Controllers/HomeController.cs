using Microsoft.AspNetCore.Mvc;

namespace PaymentProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Payment");
        }
    }
}