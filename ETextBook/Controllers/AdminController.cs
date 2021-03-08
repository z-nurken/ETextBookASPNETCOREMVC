using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Models.AdminVM;
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
        public async Task<IActionResult> About() 
        {
            return View(await adminBusinessManager.GetAboutViewModel(User));
        }

        [HttpPost] 
        public async Task<IActionResult> UpdateAbout(AboutViewModel aboutViewModel) 
        {
           await adminBusinessManager.UpdateAbout(aboutViewModel, User);
            return RedirectToAction("About"); 
        }
    }
}
