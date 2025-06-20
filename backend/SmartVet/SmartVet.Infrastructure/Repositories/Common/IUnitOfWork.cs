namespace SmartVet.Infrastructure.Repositories.Common
{
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}
