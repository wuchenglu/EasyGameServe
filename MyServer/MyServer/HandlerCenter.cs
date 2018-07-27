using NetFrame;
using NetFrame.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer
{
    public class HandlerCenter : AbsHandlerCenter
    {

        private int index = 0;
        /// <summary>
        /// 账号接口
        /// </summary>
        private HandlerInterface Accaout;
        /// <summary>
        /// 初始化事务接口
        /// </summary>
        public HandlerCenter()
        {
            //Accaout=
        }
    
        public override void ClientConnect(UserToken token)
        {
            Console.WriteLine("有客户端连接了");
            index++;
            Console.WriteLine("当前连接人数:" + index);
        }
        public override void ClientClose(UserToken token, string error)
        {
            Console.WriteLine("有客户端断开了");
            index--;
            Console.WriteLine("当前连接人数:" + index);
        }


        public override void MessageReceive(UserToken token, object message)
        {
            SocketModel model = message as SocketModel;
        }
    }
}
