using KonusarakOgrenChatClient.BLL;
using KonusarakOgrenChatService.SL;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Xunit;

namespace KonusarakOgren.Tests
{
    public class TestMain
    {

        private myServer _server;
        private myClient _client;




        public TestMain()
        {


                _server = new myServer();
                _client = new myClient();
            
        }


        [Fact]
        public void FloodTest()
        {


            for (int i = 0; i <= 50; i++)
            {

                Assert.True(_client.isConnected());

                _client.SendMessage(DateTime.Now.Ticks.ToString());

                
            }
               


            

        }



    }
}
