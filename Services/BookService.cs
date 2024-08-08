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

        public Task<IEnumerable<Author>> GetAllAuthors()
        {
            return _unitOfWork.AuthorRepository.GetAll();
        }

        public Task<Author>? GetAuthorById(int id)
        {
            return _unitOfWork.AuthorRepository.GetById(id);
        }

        public Task<bool> AddAuthor(Author author)
        {
            return _unitOfWork.AuthorRepository.Add(author);
        }

        public Task<bool> UpdateAuthor(Author author)
        {
            return _unitOfWork.AuthorRepository.Update(author);
        }

        public Task<bool> DeleteAuthorAsync(int id)
        {
            return _unitOfWork.AuthorRepository.Delete(id);
        }
    }
}
