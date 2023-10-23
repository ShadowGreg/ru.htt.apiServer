namespace ru.htt.apiServer.Core.Abstractions.Repositories;

public interface IRepository<T>
    {
    Task<IEnumerable<T>> GetAllAsync();

    Task<IEnumerable<T>> GetJoinAsync();
}