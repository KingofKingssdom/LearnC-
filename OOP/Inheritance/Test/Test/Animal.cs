using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Animal
    {
        public string Name { set; get; }
        protected int Age { set; get; }

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void Run()
        {
            Console.WriteLine("Animal is runing");
        }
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}
