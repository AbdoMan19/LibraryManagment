using LibraryManagment.Models;
using LibraryManagment.Repositories;
using LibraryManagment.Services;
using LibraryManagment.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagment.Controllers
{
    public class BookController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private BookService _bookService;
        public BookController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
            _bookService=new BookService(_unitOfWork);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var authors = await _bookService.GetAllAuthors();
            ViewData["AuthorId"] = new SelectList(authors, "Id", "Id");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            book.Author = await _bookService.GetAuhtorById(book.AuthorId);
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _bookService.AddBook(book) == false) return StatusCode(500, "An error occurred while creating the author.");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Book book)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _bookService.UpdateBook(book) == false) return StatusCode(500, "An error occurred while updating the author.");
            var authors = await _bookService.GetAllAuthors();
            ViewData["AuthorId"] = new SelectList(authors, "Id", "Id", book.AuthorId);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            Book? book = await _bookService.GetBookById(id);
            if (book is null) return NotFound();
            if (await _bookService.DeleteBook(book) == false) return StatusCode(500, "An error occurred while deleting the author.");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Index()
        {
            var model=await _bookService.GetAllBooks();
            return View(model);
        }
    }
}
