using LibraryManagment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository? _authorRepository=null;
        public AuthorController(IAuthorRepository authorRepository) {
            _authorRepository = authorRepository;
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
