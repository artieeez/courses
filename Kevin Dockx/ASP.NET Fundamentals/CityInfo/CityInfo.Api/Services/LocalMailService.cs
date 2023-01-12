namespace CityInfo.Api.Services
{
    public class LocalMailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettings:mailToAdress"];
            _mailFrom = configuration["mailSettings:mailFromAdress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                    $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
