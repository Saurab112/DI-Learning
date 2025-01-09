namespace Dependency_Injection.Services
{
	public class SimpleMessageService : IMessageService
	{
		public string GetWelcomeMessage()
		{
			return "Welcome to our asp.net core application";
		}
	}
}
