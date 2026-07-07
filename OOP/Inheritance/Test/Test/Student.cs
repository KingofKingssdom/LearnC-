using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Student : Person
    {
        public string School { set; get; }
        public Student(string name) : base(name) {
            Console.WriteLine("Goi constructor tu lop student nhung ke thua tu lop Person");
        }
    }
}
