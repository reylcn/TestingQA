using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Helpers
{
    public class Utilities
    {
        public static void SendScreenshotEmail(string screenshotPath)
        {
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("mnaumovic7@gmail.com"),
                Subject = "Test Mail - 1",
                Body = "mail with attachment"
            };
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("someemail@gmail.com", "********")
            };
            Attachment attachment = new Attachment(screenshotPath);
            mail.To.Add("mnaumoviv7@gmail.com");
            mail.Attachments.Add(attachment);

            //smtp.Send(mail);
        }
    }
}
