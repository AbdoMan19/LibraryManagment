using LibraryManagment.Models;

namespace LibraryManagment.Repository
{
    public interface IBorrowRepository
    {
        IEnumerable<Borrow> GetAllBorrows();
        Borrow GetBorrowById(int id);
        bool AddBorrow(Borrow borrow);
        bool UpdateBorrow(Borrow borrow);
        bool DeleteBorrow(int id);
    }
}
