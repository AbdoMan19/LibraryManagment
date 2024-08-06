using LibraryManagment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberRepository _memberRepository;
        public MemberController(IMemberRepository memberRepository) {
            _memberRepository = memberRepository;
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
