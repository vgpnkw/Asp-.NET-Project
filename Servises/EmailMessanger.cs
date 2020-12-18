using System;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiPedia.Data;

namespace WikiPedia.Servises
{
    public interface IEmailMessanger
    {
        void SendMsg(Models.EmailMessage msg);
    }
    public class EmailMessanger : IEmailMessanger
    {
        private readonly IEmailConfiguration _emailConfiguration;
        private readonly SmtpClient smtpClient = new SmtpClient();

        public EmailMessanger(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
            smtpClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);

            smtpClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
        }

        public async void SendMsg(Models.EmailMessage msg)
        {
            MimeMessage emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(msg.From, _emailConfiguration.SmtpUsername));
            foreach (string address in msg.ToAddresses)
            {
                emailMessage.To.Add(new MailboxAddress("User", address));
            }
            emailMessage.Subject = msg.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = msg.Content };

            await smtpClient.SendAsync(emailMessage);
        }
    }
}
