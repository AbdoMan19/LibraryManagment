using LibraryManagment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class BorrowController : Controller
    {
        private readonly IBorrowRepository? _borrowRepository=null;
        public BorrowController(IBorrowRepository borrowRepository)
        {
            _borrowRepository = borrowRepository;
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
