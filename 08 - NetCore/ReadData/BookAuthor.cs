using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadData
{
    public class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        public Author? Author { get; set; }
        public Book? Book { get; set; }
    }
}