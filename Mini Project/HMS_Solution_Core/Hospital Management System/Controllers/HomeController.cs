using Hospital_Management_System.models;
using Hospital_Management_System.Models;
using Hospital_Management_System.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IDbAccess<UserTable, int> userAccess;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Login()
        {

            return View();
        }

        public async Task<IActionResult> LoginSuccess(int UserId,string password)
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}