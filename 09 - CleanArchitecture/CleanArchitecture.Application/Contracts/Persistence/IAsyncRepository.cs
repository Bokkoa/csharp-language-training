using CleanArchitecture.Domain.Common;
using System.Linq.Expressions;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        // Expression linq
        // expression is a sql query function, ej: IQueryable
        // Where(Expression<Func<T,bool>> predicate

        // Func linq
        // function is a in memory function use, ej: IEnumerable
        // Where(Func<T,bool> predicate)
        
        // SYNTAX IS VERY SIMILAR
        // get all
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate); // expression transforms into a sql query
        // get order by
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                         string includeString = null,
                                         bool disableTracking = true);
        // get with paginated results and with relations
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                          List<Expression<Func<T, object>>> includes = null,
                                          bool disableTracking = true);
        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync (T entity);
        Task<T> DeleteAsync(T entity);
    }
}
