using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
	public class LoginAndRegisterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Register()
        {
            return View();
        }
    }
}
