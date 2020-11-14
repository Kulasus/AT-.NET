using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using MailKit;
using MimeKit;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService
{
    static class EmailSender
    {
        public static void sendMail()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Session.settingsPath);
            var messageToSend = new MimeMessage()
            {
                Sender = new MailboxAddress(
                    xml.SelectSingleNode("/info/email/sender/name").InnerText.ToString(),
                    xml.SelectSingleNode("/info/email/sender/address").InnerText.ToString()
                    ),
                Subject = xml.SelectSingleNode("/info/email/sender/subject").InnerText.ToString()
            };
            messageToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = @"Hey, this is just a test message."
            };
            messageToSend.To.Add(new MailboxAddress(
                    xml.SelectSingleNode("/info/email/receiver/name").InnerText.ToString(),
                    xml.SelectSingleNode("/info/email/receiver/address").InnerText.ToString()));
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect(
                    xml.SelectSingleNode("/info/email/sender/smtp").InnerText.ToString(),
                    Int32.Parse(xml.SelectSingleNode("/info/email/sender/port").InnerText.ToString()),
                    true);
                smtp.Authenticate(
                    xml.SelectSingleNode("/info/email/sender/address").InnerText.ToString(),
                    xml.SelectSingleNode("/info/email/sender/password").InnerText.ToString());
                smtp.Send(messageToSend);
                smtp.Disconnect(true);
            }
        }
    }
}
