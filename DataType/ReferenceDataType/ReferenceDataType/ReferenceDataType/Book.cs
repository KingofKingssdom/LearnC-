using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceDataType
{
    public class Book
    {
        public string Title { set; get; }
        public string Author { set; get; }
        public double Price { set; get; }
        public Book() {}
        public Book(string Title, string Author, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

    }
}
