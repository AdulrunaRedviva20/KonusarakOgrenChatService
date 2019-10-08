using KonusarakOgrenChatClient.BLL;
using System;

namespace KonusarakOgrenChatClient
{
    class Program
    {
        static void Main(string[] args)
        {



            myClient client = new myClient();

            client.SendMessage("Naber la");

            Console.WriteLine("Hello World!");
        }
    }
}
