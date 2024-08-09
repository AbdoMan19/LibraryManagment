using LibraryManagment.Models;
using LibraryManagment.UnitOfWork;

namespace LibraryManagment.Services
{ 
    public class BookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Book>> GetAllBooks()
        {
            return _unitOfWork.BookRepository.GetAll();
        }

        public Task<Book?> GetBookById(int id)
        {
            return _unitOfWork.BookRepository.GetById(id);
        }

        public async Task<bool> AddBook(Book book)
        {
            await _unitOfWork.BookRepository.Add(book);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateBook(Book book)
        {
            _unitOfWork.BookRepository.Update(book);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteBook(Book book)
        {
            _unitOfWork.BookRepository.Delete(book);
            return await _unitOfWork.SaveAsync();
        }
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _unitOfWork.AuthorRepository.GetAll();
        }
         public async Task<Author?> GetAuhtorById(int id)
        {
            return await _unitOfWork.AuthorRepository.GetById(id);
        }
    }
}
