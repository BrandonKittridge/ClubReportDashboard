using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubReportDashboard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClubReportDashboard.Controllers
{
    public class UserAccountController : Controller
    {
        public IUserRepository userRepository;

        public UserAccountController(IUserRepository userRepo)
        {
            userRepository = userRepo;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminUserList()
        {
            return View(model: userRepository.Users);
        }

        public IActionResult ModifyUser()
        {
            return View(model: userRepository.Users);
        }
    }
}
