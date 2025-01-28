namespace ScopedService.ServiceContracts
{
	public interface IEmailNotificationService
	{
		void SendEmail(string to, string subject, string message);
	}
}
