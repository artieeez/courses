namespace CityInfo.Api.Services
{
    public class CloudMailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;
        public CloudMailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettings:mailToAdress"];
            _mailFrom = configuration["mailSettings:mailFromAdress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                    $"with {nameof(CloudMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
