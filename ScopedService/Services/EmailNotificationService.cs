using ScopedService.ServiceContracts;

namespace ScopedService.Services
{
	public class EmailNotificationService: IEmailNotificationService
	{
		private readonly ILogger<EmailNotificationService> _logger;

		public EmailNotificationService(ILogger<EmailNotificationService> logger)
		{
			_logger = logger;
		}

		public void SendEmail(string to, string subject, string message)
		{
			// Simulate sending an email
			_logger.LogInformation($"Sending email to {to}: Subject: {subject}, Message: {message}");
		}
	}
}
