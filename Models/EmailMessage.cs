using System;
using System.Collections.Generic;

namespace WikiPedia.Models
{
    public class EmailMessage
    {
        public List<string> ToAddresses { get; set; } = new List<string>();
        public string From { get; set; } = "wikipediaclone";
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
