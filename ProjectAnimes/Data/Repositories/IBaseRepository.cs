using ProjectAnimes.Models.Entities;

namespace ProjectAnimes.Data.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task Remove(Guid id);
        Task<T?> GetById(Guid id);
        Task<List<T>> GetAll();
    }
}
