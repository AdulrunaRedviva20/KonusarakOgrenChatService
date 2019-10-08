using KonusarakOgren.CommonLayer;
using KonusarakOgrenCommonLayer.CL;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace KonusarakOgrenCommonLayer.CL
{
    public static class SocketExtensions
    {

        
        

        public static void Warning(this SocketInfo socketInfo, string message)
        {

           


            socketInfo.totalWarning++;
            var _bytes = myHelper.StrToByte(message);
            socketInfo.socket.Send(_bytes);


        }

        public static void Kick(this SocketInfo socketInfo, string kickMessage)
        {
            var _bytes = myHelper.StrToByte(kickMessage);
            socketInfo.socket.Send(_bytes);

            socketInfo.socket.Disconnect(true);
            
        }

        

    }



}
