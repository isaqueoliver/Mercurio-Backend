using Back.Mercurio.Domain.Entities;

namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
