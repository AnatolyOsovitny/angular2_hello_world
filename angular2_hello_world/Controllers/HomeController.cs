using Microsoft.AspNetCore.Mvc;

namespace angular2_hello_world.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
