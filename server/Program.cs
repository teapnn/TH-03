using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            server.Bind(ipep);
            EndPoint ep = ipep;
            Random r = new Random();

            byte[] nhan = new byte[1024];

            while (true)
            {
                int rec = server.ReceiveFrom(nhan, ref ep);
                string s = Encoding.ASCII.GetString(nhan, 0, rec);
                string gui = r.Next(0, 3).ToString();
                byte[] send = Encoding.ASCII.GetBytes(gui);
                server.SendTo(send, ep);
                XuLyServerGui(gui);
            }
        }
        static void XuLyServerGui(string s)
        {
            if (s == "0")
                Console.WriteLine("Keo");
            else if (s == "1")
                Console.WriteLine("Bua");
            else
                Console.WriteLine("Bao");
        }
    }
}
