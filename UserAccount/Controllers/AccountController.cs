using Microsoft.AspNetCore.Mvc;

namespace UserAccount.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
