using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace HttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 81);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                var writer = new StreamWriter(client.GetStream());
                string content = GetLog();
                string html = "Christoph Jörimann & Gowthaam Yogeswaran" + Environment.NewLine + content;
                SendHttpResponse(writer, html);
                client.Close();
            }
        }

        private static string GetLog()
        {
            string content = "";
            try
            {
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    content = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found or locked!");
            }
            return content;
        }

        private static void SendHttpResponse(StreamWriter writer, string body)
        {
            writer.WriteLine("HTTP/1.1 200 OK");
            writer.WriteLine("Content-Type: text/plain");
            writer.WriteLine("Content-Length: " + Encoding.ASCII.GetByteCount(body));
            writer.WriteLine();
            writer.WriteLine(body);
            writer.Flush();
        }
    }
}
