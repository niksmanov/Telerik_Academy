﻿using System;

namespace Task2
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return (int)(this.Price - other.Price);
        }
    }
}
