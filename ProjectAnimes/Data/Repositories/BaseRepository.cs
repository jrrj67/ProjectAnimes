using Microsoft.EntityFrameworkCore;
using ProjectAnimes.Data.Context;
using ProjectAnimes.Models.Entities;

namespace ProjectAnimes.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext _context;

        public BaseRepository(ProjectContext context)
        {
            _context = context;
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public virtual async Task<T> Create(T obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T?> GetById(Guid id)
        {
            var obj = await _context.Set<T>()
                                    .AsNoTracking()
                                    .Where(x => x.Id == id)
                                    .ToListAsync();

            return obj.FirstOrDefault();
        }

        public virtual async Task Remove(Guid id)
        {
            var obj = await GetById(id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }

        public virtual async Task<T> Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }
    }
}
