

namespace ReadData
{
    public class Price
    {
        public int PriceId { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Sale { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}