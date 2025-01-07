using Dependency_Injection.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
	public class HomeController : Controller
	{
		private readonly IMessageService _messageService;
		public HomeController(IMessageService messageService)
		{
			_messageService = messageService; 
		}
		[Route("/")]
		public IActionResult Index()
		{
			string message = _messageService.GetWelcomeMessage();
			ViewBag.Message = message;
			return View();
		}
	}
}

/* for future reference
 * 🔑 Key Points to Remember:
Service Interface and Implementation:
We define an interface (IMessageService) and implement it with SimpleMessageService.
Registration in Program.cs:
We use AddScoped to tell ASP.NET to create a new instance of the service per request.
Dependency Injection:
ASP.NET injects the service automatically into the HomeController
*/
