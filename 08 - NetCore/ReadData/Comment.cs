
namespace ReadData
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Student { get; set; }
        public int Score { get; set; }
        public string? CommentText {get; set;}
        public int BookId { get; set;}

        public Book? Book { get; set; }

    }
}