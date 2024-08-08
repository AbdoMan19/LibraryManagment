using LibraryManagment.Models;
using LibraryManagment.Repositories;

namespace LibraryManagment.UnitOfWork
{
    public interface IUnitOfWork{
        IRepository<Book> BookRepository {  get; }
        IRepository<Member> MemberRepository {  get; }
        IRepository<Borrow> BorrowRepository {  get; }
        IRepository<Author> AuthorRepository {  get; }
        Task SaveAsync();
    }
}
