using System;
using System.Collections.Generic;
using System.Text;

namespace LearnClassAndObject
{
    public class Product
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public void PrintInfo()
        {
            Console.WriteLine($"San pham: {Name} co gia {Price}");
        }
    }
}
