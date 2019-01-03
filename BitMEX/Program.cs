using System;

namespace BitMEX
{
    class Program
    {
        private static string bitmexKey = "YOUR-API-KEY";
        private static string bitmexSecret = "YOUR-API-SECRET";

        private static void Main(string[] args)
        {
            Program p = new Program();
            p.Run(args);
        }

        private void Run(string[] args)
        {
            BitMEXApi bitmex = new BitMEXApi(bitmexKey, bitmexSecret);
            // var orderBook = bitmex.GetOrderBook("XBTUSD", 3);
            var orders = bitmex.GetOrders();
            // var orders = bitmex.DeleteOrders();
            Console.WriteLine(orders);
        }
    }
}
