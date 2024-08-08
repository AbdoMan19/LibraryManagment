using LibraryManagment.Data;
using LibraryManagment.Migrations;
using LibraryManagment.Models;
using LibraryManagment.Repositories;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagment.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext applicationDbContext) {
            _context = applicationDbContext;
        }
        private IRepository<Member>? _memberRepository;
        private IRepository<Borrow>? _borrowRepository;
        private IRepository<Book>? _bookRepository;
        private IRepository<Author>? _authorRepository;
        public IRepository<Author> AuthorRepository => _authorRepository ??= new GenericRepo<Author>(_context);
        public IRepository<Book> BookRepository => _bookRepository ??= new GenericRepo<Book>(_context);
        public IRepository<Member> MemberRepository => _memberRepository ??= new GenericRepo<Member>(_context);
        public IRepository<Borrow> BorrowRepository => _borrowRepository ??= new GenericRepo<Borrow>(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }




    }
}
