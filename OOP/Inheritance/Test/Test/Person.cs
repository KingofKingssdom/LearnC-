using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Person
    {
        public string Name { set; get; }
        public Person() { }
        public Person(string name)
        {
            this.Name = name;
        }

    }
}
