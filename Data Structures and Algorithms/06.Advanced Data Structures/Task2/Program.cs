using System;
using System.Diagnostics;
using Wintellect.PowerCollections;

namespace Task2
{
    class Program
    {
        const int productsSearches = 500000;
        const int priceSearces = 10000;

        static void Main()
        {
            var products = new OrderedBag<Product>();

            var random = new Random();

            for (int i = 0; i < productsSearches; i++)
            {
                var price = random.Next(1, 1000000);
                var product = new Product()
                {
                    Price = price,
                    Name = i.ToString()
                };

                products.Add(product);
            }

            var stopwatch = new Stopwatch();

            for (int i = 0; i < priceSearces; i++)
            {
                var minRange = 0;
                var maxRange = 0;

                minRange = random.Next(1, 100000);
                maxRange = random.Next(1, 1000000);

                stopwatch.Start();
                var productsInRange = products.Range(new Product() { Price = minRange }, true, new Product() { Price = maxRange }, true);
                stopwatch.Stop();

                Console.WriteLine($"Products min range: {minRange}, Products max range: {maxRange}, Products count in range: {productsInRange.Count}, Search time: {stopwatch.Elapsed}");
                stopwatch.Reset();
            }
        }
    }
}