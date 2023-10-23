using ru.htt.apiServer.Core;
using ru.htt.apiServer.Core.Abstractions.Repositories;

namespace ru.htt.apiServer.DataAccess.Repositories;

public class InMemoryRepository<T>
    : IRepository<T> {
    protected IEnumerable<T> Data { get; set; }

    public InMemoryRepository(IEnumerable<T> data) {
        Data = data;
    }

    public Task<IEnumerable<T>> GetAllAsync() {
        return Task.FromResult(Data);
    }

    public Task<IEnumerable<T>> GetJoinAsync() {
        return Task.FromResult(Data);
    }
}