using LibraryManagment.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryManagment.Repositories
{
    public class GenericRepo<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepo(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task  Add(T entity)
        {
           await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
         
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return  await (query).ToListAsync();
            }
            else
            {
                return query.ToList();
            }
        }

        public async Task<T?> GetById(int id)
        {
            
            return await _dbSet.FindAsync(id);       
        }

        public  void Update(T entity)
        {
             _dbSet.Update(entity);  
     
        }

        
    }
}
