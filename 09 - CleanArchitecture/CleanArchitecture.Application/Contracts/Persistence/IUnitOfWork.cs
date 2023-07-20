using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;
        IStreamerRepository StreamerRepository { get; }
        IVideoRepository VideoRepository { get; }
        Task<int> Complete();
    }
}
