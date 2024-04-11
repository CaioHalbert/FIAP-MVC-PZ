using FIAP_MVC_PZ.Data;
using FIAP_MVC_PZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FIAP_MVC_PZ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register(User resquest)
        {
            var user = _dataContext.PZ_Users.FirstOrDefault(x => x.UserEmail == resquest.UserEmail);
            if (user != null)
            {
                return BadRequest("Usuário ja existe");
            }
            _dataContext.Add(resquest);
            _dataContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
