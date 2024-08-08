using LibraryManagment.Repositories;
using LibraryManagment.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class MemberController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberController(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
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
