using Microsoft.EntityFrameworkCore;
using StudentAPI.Contracts;
using StudentAPI.Data;

namespace StudentAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StudentDbContext _context;

        public GenericRepository(StudentDbContext context)
        {
            _context = context;
            
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetFourAsync()
        {
            return await _context.Set<T>().Take(4).ToListAsync();
        }
    }
}