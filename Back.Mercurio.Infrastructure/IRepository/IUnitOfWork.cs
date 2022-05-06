namespace Back.Mercurio.Infrastructure.IRepository
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
