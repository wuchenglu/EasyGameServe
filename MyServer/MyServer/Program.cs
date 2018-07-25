using System;
using NetFrame;
using NetFrame.Auto;

namespace MyServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerStart serverStart = new ServerStart(10);
            serverStart.LD = LengthEncoding.decode;
            serverStart.LE = LengthEncoding.encode;
            serverStart.encode = MessageEncoding.encode;
            serverStart.decode = MessageEncoding.decode;
            //serverStart.center = new HandlerCenter();
            serverStart.Start(6650);
            Console.WriteLine("服务器已启动");
            while (true)
            {

            }
        }
    }
}
