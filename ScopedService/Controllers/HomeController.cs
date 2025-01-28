using Microsoft.AspNetCore.Mvc;
using ScopedService.ServiceContracts;

namespace ScopedService.Controllers
{
	public class HomeController : Controller
	{
		private readonly IShoppingCartService _shoppingCartService;
		private readonly IEmailNotificationService _emailNotificationService;
		
		public HomeController(IShoppingCartService shoppingCartService, IEmailNotificationService emailNotificationService)
		{
			_shoppingCartService = shoppingCartService;
			_emailNotificationService = emailNotificationService;
		}
		[Route("/addtocart")]
		public IActionResult AddToCart()
		{
			_shoppingCartService.AddItem("Mac book air 16gb", 1);
			_shoppingCartService.AddItem("Iphone 12 pro", 2);

			// Sending an email notification
			_emailNotificationService.SendEmail("user@example.com", "Items Added to Cart", "You have added items to your shopping cart.");
			var items = _shoppingCartService.GetItems();
			ViewBag.Items = items;

			return View();
		}

		[Route("/removefromcart")]
		public IActionResult RemoveFromCart()
		{
			_shoppingCartService.RemoveItem("Mac book air 16gb");

			var items = _shoppingCartService.GetItems();
			ViewBag.Items = items;
			ViewBag.TotalPrice = _shoppingCartService.GetTotalPrice();

			return View("AddToCart");
		}
	}
}
