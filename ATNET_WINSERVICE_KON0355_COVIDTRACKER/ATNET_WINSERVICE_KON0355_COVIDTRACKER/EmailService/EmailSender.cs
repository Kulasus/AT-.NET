using System;
using System.Collections.Generic;
using System.IO;
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

            var attachment = new MimePart("image", "gif")
            {
                Content = new MimeContent(File.OpenRead(Session.projectPath + @"\Resources\Graph.jpg")),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(Session.projectPath + @"\Resources\Graph.jpg")
            };

            var body = new TextPart("plain")
            {
                Text = @"Hey there,

                You can find new covid-19 cases in Czech Republic for last 14 days graph in the attachment.

                Yours faithfull,
                Windows Service"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(body);
            multipart.Add(attachment);

            message.Body = multipart;

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
