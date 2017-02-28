using System;

using SherEShop.Server;
using SherEShop.Server.Common.DummyDataProvider;
using SherEShop.Utilities;

namespace SherEShop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyGenerator.GenerateDatabase();

            Console.WriteLine("Hello world");
            var server = new Servovec();
            server.Run();
        }
    }
}
