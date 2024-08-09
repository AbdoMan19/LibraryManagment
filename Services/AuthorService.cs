using LibraryManagment.Models;
using LibraryManagment.UnitOfWork;

namespace LibraryManagment.Services
{
    public class AuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Author>> GetAllAuthors()
        {
            return  _unitOfWork.AuthorRepository.GetAll();
        }

        public Task<Author?> GetAuthorById(int id)
        {
            return _unitOfWork.AuthorRepository.GetById(id);
        }

        public  async Task<bool> AddAuthor(Author author)
        {
            await _unitOfWork.AuthorRepository.Add(author);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAuthor(Author author)
        {
            _unitOfWork.AuthorRepository.Update(author);
            return await _unitOfWork.SaveAsync();
        }

        public  async Task<bool> DeleteAuthor(Author author)
        {
            _unitOfWork.AuthorRepository.Delete(author);
            return await _unitOfWork.SaveAsync();
        }

    }
}
