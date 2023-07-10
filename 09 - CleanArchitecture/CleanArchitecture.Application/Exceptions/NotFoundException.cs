
namespace CleanArchitecture.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"Entity \"{name}\" not found with the given id {key}")
        {
        }
    }
}
