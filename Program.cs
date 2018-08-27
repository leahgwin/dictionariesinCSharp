using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GOOGL", "Google");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("APPL", "Apple");


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();


            purchases.Add((ticker: "CAT", shares: 32, price: 141.83));
            purchases.Add((ticker: "GM", shares: 80, price: 37.56));
            purchases.Add((ticker: "APPL", shares: 49, price: 218.07));
            purchases.Add((ticker: "AMZN", shares: 3, price: 1918.62));
            purchases.Add((ticker: "GOOGL", shares: 8, price: 1253.33));






        }


    }
}
