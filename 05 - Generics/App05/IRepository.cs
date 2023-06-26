
namespace App05
{
    public interface IRepository<T> where T: Person, IComparable<T> 
        // 'where' indicates that IComparable is required and also classes must inherit from Person abstract class
    {
        IEnumerable<T> List();
        IEnumerable<T> OrderList();
    }
}
