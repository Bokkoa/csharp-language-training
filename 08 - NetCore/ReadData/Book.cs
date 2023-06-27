using System;
using System.Collections.Generic;

namespace ReadData
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublishDate { get; set; }
        public Price? PriceSale { get; set; }

        public ICollection<Comment>? Comments { get; set; }

        public ICollection<BookAuthor> AuthorLink { get; set; }
    }
}
