using ETextBook.BusinessManagers.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETextBook.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminBusinessManager adminBusinessManager;
        public AdminController(IAdminBusinessManager adminBusinessManager)
        {
            this.adminBusinessManager = adminBusinessManager;
        }
        public async Task<IActionResult> Index()
        {
            return View( await adminBusinessManager.GetAdminDashboard(User));
        }
    }
}
