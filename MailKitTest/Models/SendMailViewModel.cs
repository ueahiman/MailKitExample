using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailKitTest.Models
{
    public class SendMailViewModel
    {
        // string to, string from, string subject, string text
        public string SendTo { get; set; }
        public string SendFrom { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }

    }
}
