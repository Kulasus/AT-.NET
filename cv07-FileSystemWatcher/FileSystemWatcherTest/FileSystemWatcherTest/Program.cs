using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;

namespace FileSystemWatcherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Users\lukas\OneDrive\Plocha\FileSystemWatch";
            watcher.Created += (object sender, FileSystemEventArgs e) => {
                WriteToLog($"Vytvořeno: {e.FullPath}");
            };
            watcher.Changed += (object sender, FileSystemEventArgs e) => {
                WriteToLog($"Upraveno: {e.FullPath}");
            };
            watcher.Deleted += (object sender, FileSystemEventArgs e) => {
                WriteToLog($"Smazáno: {e.FullPath}");
            };
            watcher.Renamed += (object sender, RenamedEventArgs e) => {
                WriteToLog($"Přejmenováno: {e.OldFullPath} na {e.FullPath}");
            };
            watcher.EnableRaisingEvents = true;

            while (true)
            {
                string data = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(data))
                {
                    break;
                }
                switch (data)
                {
                    case "log":
                        ReadLog();
                        break;
                    case "mail":
                        SendMail();
                        break;
                }
            }

            Console.ReadLine();
        }

        private static void SendMail()
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("atnet2019@seznam.cz"));
            message.To.Add(new MailboxAddress("lukas.kondiolka@seznam.cz"));
            message.Subject = "Předmět";

            BodyBuilder bBuilder = new BodyBuilder();
            bBuilder.HtmlBody = "<h1>Nadpis</h1><strong style = \"color: red;\">message</strong>";

            message.Body = bBuilder.ToMessageBody();

            using SmtpClient client = new SmtpClient();
            client.Connect("smtp.seznam.cz",465,true);
            client.Authenticate("atnet2019@seznam.cz", "janousek");
            client.Send(message);
            client.Disconnect(true);
        }

        private static void ReadLog()
        {
            using IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();
            using IsolatedStorageFileStream fileStream = storage.OpenFile("log.txt", FileMode.OpenOrCreate);
            using StreamReader sr = new StreamReader(fileStream);

            LinkedList<string> data = new LinkedList<string>();
            string line;
            while((line = sr.ReadLine()) != null)
            {
                data.AddLast(line);
                if(data.Count > 5)
                {
                    data.RemoveFirst();
                }
            }
            foreach(string message in data)
            {
                Console.WriteLine(message);
            }
        }


        private static void WriteToLog(string message)
        {
            using IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();
            using IsolatedStorageFileStream fileStream = storage.OpenFile("log.txt", FileMode.OpenOrCreate | FileMode.Append);
            //using FileStream fs = new FileStream("log.txt", FileMode.OpenOrCreate | FileMode.Append);
            using StreamWriter sw = new StreamWriter(fileStream);
            sw.WriteLine(message);
        }
    }
}
