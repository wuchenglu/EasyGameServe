using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFrame;
using NetFrame.Auto;

namespace MyServer
{
    interface HandlerInterface
    {
        /// <summary>
        /// 客户端断开
        /// </summary>
        /// <param name="token"></param>
        /// <param name="error"></param>
        void ClientClose(NetFrame.UserToken token, string error);
        /// <summary>
        ///信息到达
        /// </summary>
        /// <param name="token"></param>
        /// <param name="message"></param>
        void MessageReceive(UserToken token, SocketModel message)
    }
}
