using LibraryManagment.Models;
using LibraryManagment.UnitOfWork;

namespace LibraryManagment.Services
{
    public class BorrowService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BorrowService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Borrow>> GetAllBorrows()
        {
            return _unitOfWork.BorrowRepository.GetAll();
        }

        public Task<Borrow?> GetBorrowById(int id)
        {
            return _unitOfWork.BorrowRepository.GetById(id);
        }

        public async Task<bool> AddBorrow(Borrow borrow)
        {
            await _unitOfWork.BorrowRepository.Add(borrow);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateBorrow(Borrow borrow)
        {
            _unitOfWork.BorrowRepository.Update(borrow);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteBorrowAsync(Borrow borrow)
        {
            _unitOfWork.BorrowRepository.Delete(borrow);
            return await _unitOfWork.SaveAsync();
        }
    }
}
