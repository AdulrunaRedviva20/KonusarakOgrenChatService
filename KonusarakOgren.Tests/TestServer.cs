using KonusarakOgrenChatService.SL;
using System;
using Xunit;

namespace KonusarakOgren.Tests
{
    public class TestServer
    {

        private myServer server;

        [Fact]
        public void CreateServer()
        {

           server = new myServer();

        }


        [Fact]
        public void TestConnect()
        {

            if (server == null) server = new myServer();

            Assert.True(server.IsActive());
        }
    }
}
