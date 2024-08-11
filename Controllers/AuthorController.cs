using LibraryManagment.Models;
using LibraryManagment.Services;
using LibraryManagment.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private AuthorService authorService;
        public AuthorController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
            authorService=new AuthorService(unitOfWork);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();   
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            if (!ModelState.IsValid)return BadRequest(ModelState);
            if (await authorService.AddAuthor(author) == false) return StatusCode(500, "An error occurred while creating the author.");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Update(Author author)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            if(await authorService.UpdateAuthor(author)==false)return  StatusCode(500, "An error occurred while updating the author.");
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Author? author =await authorService.GetAuthorById(id);
            if (author is null)return NotFound();
            return View(author);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Author? author = await authorService.GetAuthorById(id);
            if (author is null) return NotFound();
            if (await authorService.DeleteAuthor(author) == false) return StatusCode(500, "An error occurred while deleting the author.");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Index()
        {
            var model = await authorService.GetAllAuthors();
            return View(model);
        }
    }
}
