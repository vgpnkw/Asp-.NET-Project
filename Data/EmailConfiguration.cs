using System;
namespace WikiPedia.Data
{
    public interface IEmailConfiguration
    {
        string SmtpServer { get; set; }
        int SmtpPort { get; set; }
        string SmtpUsername { get; set; }
        string SmtpPassword { get; set; }
    }
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
    }
}
