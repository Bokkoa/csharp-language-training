

namespace App05
{
    public interface IPersonRepository<T>: IRepository<T> where T: Person, IComparable<T>, new() 
        // new() indicates that T must have a constructor without params
        // is optional then have more constructors with other kind of behaviour
    {
        IEnumerable<T> Search(string name);
        T Create(FullName name);
        T DefaultCreate();
    }

    // ANOTHER WAY TO CREATE A GENERIC interface
    // specification in method

    public interface IAnotherPersonRepository
    {
        IEnumerable<T> Search<T>(string name) where T : Person;

        T Create<T>(FullName name) where T : Person;
        T DefaultCreate<T>() where T : Person;
    }
}
