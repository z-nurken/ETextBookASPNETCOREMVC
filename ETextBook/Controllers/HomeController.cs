using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ETextBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogBusinessManager blogBusinessManager;

        public HomeController(ILogger<HomeController> logger, IBlogBusinessManager blogBusinessManager)
        {
            _logger = logger;
            this.blogBusinessManager = blogBusinessManager;
        }

        public IActionResult Index(string searchString, int? page)
        {
            return View(blogBusinessManager.GetIndexViewModel(searchString,page));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
