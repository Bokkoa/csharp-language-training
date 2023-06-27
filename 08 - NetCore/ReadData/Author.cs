using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadData
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Surname {get; set; }
        public string? Grade { get; set; }
        public byte[]? ProfilePic { get; set; }

        public ICollection<BookAuthor> BookLink { get; set;}
    }
}