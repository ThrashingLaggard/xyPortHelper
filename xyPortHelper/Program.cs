using System.Net.Sockets;
using xyPorts.TCP;
using xyPorts.UDP;

internal class Program
{
    public static int Main(string[] args)
    {


        xyUdpClient.ReceiveDataUDP(17);

        Console.ReadKey();
        return 0;
    }
}