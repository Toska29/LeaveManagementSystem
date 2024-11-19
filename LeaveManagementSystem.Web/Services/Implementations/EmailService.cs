using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementSystem.Web.Services.Implementations
{
    public class EmailService(IConfiguration _configuration) : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            int port = Convert.ToInt32(_configuration["EmailSettings:Port"]);
            string? server = _configuration["EmailSettings:Server"];
            string? sendFrom = _configuration["EmailSettings:DefaultSender"];

            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(sendFrom),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true,
            };
           mailMessage.To.Add(new MailAddress(email));
           using SmtpClient smtpClient = new SmtpClient(server, port);
           await smtpClient.SendMailAsync()
        }
    }
}
