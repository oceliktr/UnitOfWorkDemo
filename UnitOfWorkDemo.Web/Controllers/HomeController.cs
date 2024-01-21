using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitOfWorkDemo.Web.Entities;
using UnitOfWorkDemo.Web.Business.Interfaces;

namespace UnitOfWorkDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public readonly IUserManager _userService;
        public HomeController(IUserManager userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<User> userList = await _userService.GetAllUser();
            if (userList == null)
            {
                return NotFound("Bulunamadı");
            }
            return View(userList);
        }


    }
}
