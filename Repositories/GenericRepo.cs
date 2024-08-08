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

        public async Task<bool> Add(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Delete(object id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    return true;
                }
                return false;
            }catch(Exception ex)
            {
                return false;
            }
            
         
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
                return  orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public async Task<T>? GetById(object id)
        {
            
            return await _dbSet.FindAsync(id);       
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);  
                return  true;
            }
            catch(Exception ex)
            {
                return false;

            }
        }
    }
}
