using System.Linq.Expressions;
namespace LibraryManagment.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "");
        Task<T?> GetById(int id);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
