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
            purchases.Add((ticker: "CAT", shares: 72, price: 111.83));
            purchases.Add((ticker: "CAT", shares: 55, price: 222.83));

            purchases.Add((ticker: "GM", shares: 80, price: 37.56));
            purchases.Add((ticker: "GM", shares: 39, price: 68.56));

            purchases.Add((ticker: "APPL", shares: 49, price: 308.07));
            purchases.Add((ticker: "APPL", shares: 18, price: 318.07));
            purchases.Add((ticker: "APPL", shares: 20, price: 118.07));

            purchases.Add((ticker: "AMZN", shares: 3, price: 918.62));
            purchases.Add((ticker: "AMZN", shares: 76, price: 1228.62));

            purchases.Add((ticker: "GOOGL", shares: 20, price: 1253.33));
            purchases.Add((ticker: "GOOGL", shares: 8, price: 993.33));
            purchases.Add((ticker: "GOOGL", shares: 99, price: 1203.33));
            purchases.Add((ticker: "GOOGL", shares: 46, price: 1003.33));


            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */
            Dictionary<string, double> stocksPurchased = new Dictionary<string, double>();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                if (stocksPurchased.ContainsKey(stocks[purchase.ticker]))
                {
                    // If it does, update the total valuation
                    stocksPurchased[stocks[purchase.ticker]] += purchase.price * purchase.shares;
                }
                else
                {
                    // If not, add the new key and set its value
                    stocksPurchased.Add(stocks[purchase.ticker], purchase.price * purchase.shares);
                }
            }
            foreach (KeyValuePair<string, double> item in stocksPurchased)
            {
                Console.WriteLine($"{item.Key}: {item.Value.ToString("C")}");
            }

        }


    }
}
