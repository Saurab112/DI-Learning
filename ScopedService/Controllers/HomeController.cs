using Microsoft.AspNetCore.Mvc;
using ScopedService.ServiceContracts;

namespace ScopedService.Controllers
{
	public class HomeController : Controller
	{
		private readonly IShoppingCartService _shoppingCartService;
		
		public HomeController(IShoppingCartService shoppingCartService)
		{
			_shoppingCartService = shoppingCartService;
		}
		[Route("/addtocart")]
		public IActionResult AddToCart()
		{
			_shoppingCartService.AddItem("Mac book air 16gb", 1);
			_shoppingCartService.AddItem("Iphone 12 pro", 2);

			var items = _shoppingCartService.GetItems();
			ViewBag.Items = items;

			return View();
		}
	}
}
