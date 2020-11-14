using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using MailKit.Net.Smtp;
using MimeKit;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService
{
    static class EmailSender
    {
        public static void sendMail()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Session.settingsPath);

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(
                xml.SelectSingleNode("/info/email/sender/name").InnerText.ToString(),
                xml.SelectSingleNode("/info/email/sender/address").InnerText.ToString()));

            message.Subject = xml.SelectSingleNode("/info/email/sender/subject").InnerText.ToString();

            message.To.Add(new MailboxAddress(
                xml.SelectSingleNode("/info/email/receiver/name").InnerText.ToString(),
                xml.SelectSingleNode("/info/email/receiver/address").InnerText.ToString()
                ));

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Test message</h1>";
            message.Body = bodyBuilder.ToMessageBody();

            using SmtpClient client = new SmtpClient();
            client.Connect(
                    xml.SelectSingleNode("/info/email/sender/smtp").InnerText.ToString(),
                    Int32.Parse(xml.SelectSingleNode("/info/email/sender/port").InnerText.ToString()),
                    true);
            client.Authenticate(
                    xml.SelectSingleNode("/info/email/sender/address").InnerText.ToString(),
                    xml.SelectSingleNode("/info/email/sender/password").InnerText.ToString()
                );
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
