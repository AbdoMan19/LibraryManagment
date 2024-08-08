using System.Linq.Expressions;
namespace LibraryManagment.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            string includeProperties = "");
        Task<T>? GetById(Object id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Object id);
    }
}
