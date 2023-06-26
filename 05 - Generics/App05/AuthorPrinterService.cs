
namespace App05
{
    internal class AuthorPrinterService
    {
        private readonly IRepository<Author> _repository;

        public AuthorPrinterService(IRepository<Author> repository)
        {
            _repository = repository;
        }


        public void PrintAuthors()
        {
            Console.WriteLine("#######Printing authors from service layer#####");
            var authors = _repository.List().ToArray();

            for(int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine(authors[i]);
            }
        }
    }
}
