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
		//constructor injection gareko
		//[Route("/")]
		//public IActionResult Index()
		//{
		//	string message = _messageService.GetWelcomeMessage();
		//	ViewBag.Message = message;
		//	return View();
		//}
		//method injection
		[Route("/")]
		public IActionResult Index([FromServices] IMessageService messageService)
		{
			string message = _messageService.GetWelcomeMessage();
			ViewBag.Message = message;
			return View();
		}

		//property injection less commonly used usually avoided hare
		/*
		 *  [FromServices]
    public IMessageService MessageService { get; set; } // Injected into the property

    public IActionResult Index()
    {
        ViewBag.Message = MessageService.GetMessage();
        return View();
    }
		*/
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

/*
 * Which to Choose?
Use Constructor Injection for most cases, especially for mandatory dependencies.
Use Method Injection for rare or one-time dependencies.
Use Property Injection for optional dependencies or special scenarios.
*/