
namespace App05
{
    public class AuthorRepository : IRepository<Author>
    {
        public IEnumerable<Author> List()
        {
            var authors = new Author[10];

            authors[0] = new Author("Vaxi", "Drez");
            authors[1] = new Author("Conejo", "Blaz");
            authors[2] = new Author("Mario", "Brod");
            authors[3] = new Author("Ba", "Nei");
            authors[4] = new Author("Pancho", "Villa");
            authors[5] = new Author("Chibi", "Naranjosidad");
            authors[6] = new Author("El", "Uriel");
            authors[7] = new Author("Mauricio", "Guerrero");
            authors[8] = new Author("Angela", "Arias");
            authors[9] = new Author("Nicole", "Lopez");

            return authors;
        }

        public IEnumerable<Author> OrderList()
        {
            throw new NotImplementedException();
        }
    }
}
