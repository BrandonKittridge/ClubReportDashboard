using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClubReportDashboard.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminUserList()
        {
            return View();
        }
        public IActionResult AdminEventSearch()
        {
            return View();
        }
        public IActionResult AdminEventsList()
        {
            return View();
        }
        public IActionResult AdminUserList2()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult CreateEvent()
        {
            return View();
        }

        public IActionResult MonthlyReport()
        {
            return View();
        }

        public IActionResult QuarterlyReport()
        {
            return View();
        }

        public IActionResult GeneratedReport()
        {
            return View();
        }

        public IActionResult EditEvent()
        {
            return View();
        }

        public IActionResult EditUser()
        {
            return View();
        }
        public IActionResult ModifyUser()
        {
            return View();
        }
        public IActionResult AdminReports()
        {
            return View();
        }
    }
}
