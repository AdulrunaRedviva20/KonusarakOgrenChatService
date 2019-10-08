using System;
using System.Collections.Generic;
using KonusarakOgrenCommonLayer.CL;
using System.Text;
using System.Net.Sockets;

namespace KonusarakOgren.CommonLayer.CL
{
    public class SocketState
    {
        public Socket socket = null;
        public const int BUFFER_SIZE = 1024;
        public byte[] buffer = new byte[BUFFER_SIZE];
        public StringBuilder sb = new StringBuilder();

        public void Clear()
        {
            buffer = new byte[BUFFER_SIZE];
        }
    }
}
