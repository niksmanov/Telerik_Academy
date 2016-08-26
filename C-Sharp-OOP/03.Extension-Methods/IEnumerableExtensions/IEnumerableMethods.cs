﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
   public static class IEnumerableMethods
    {
        public static int Sum(this IEnumerable<int> collection) => Enumerable.Sum(collection);

        public static int Product(this IEnumerable<int> collection)
        {
            int product = 1;
            product = collection.Aggregate(product, (current, item) => current * item);
            return product;
        }

        public static int Min(this IEnumerable<int> collection)=> Enumerable.Min(collection.Concat(new[] { int.MaxValue }));

        public static int Max(this IEnumerable<int> collection) => Enumerable.Max(collection.Concat(new[] { int.MinValue }));

        public static double Average(this IEnumerable<int> collection) => collection.Sum() / collection.Count();
    }
}
