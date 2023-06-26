using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Book : Publish
    {
        private string _author;
        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public Book(string name, string author, int pages, decimal price) 
            :base (name, price, pages)
        {
            _author = author;
        }

        public override string GetDescription() => $"Book {Name} by {Author} with {Pages} number of pages";
        
    }
}
