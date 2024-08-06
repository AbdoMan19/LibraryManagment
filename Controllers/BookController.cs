using LibraryManagment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository? _bookRepository=null;
        public BookController(IBookRepository bookRepository) { 
            _bookRepository = bookRepository;
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
