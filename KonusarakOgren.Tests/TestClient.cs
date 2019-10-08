using KonusarakOgrenChatClient.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KonusarakOgren.Tests
{
    
    public class Client
    {

        myClient client;

        public Client()
        {
            if (client == null) client = new myClient();
        }

        [Fact]
        public  void CreateClient()
        {

           if(client == null)  client = new myClient();
        }


        [Fact]
        public void TestConnect()
        {



            Assert.True(client.isConnected());

            client.SendMessage("aaaaa bbbbbbb cccccccc");
            

            Assert.True(client.CloseConnection());

            
                        
        }
           

       
    }
}
