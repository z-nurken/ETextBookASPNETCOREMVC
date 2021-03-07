using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Data.Models;
using ETextBook.Models.AdminVM;
using ETextBook.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETextBook.BusinessManagers
{
    public class AdminBusinessManager : IAdminBusinessManager
    {
        private UserManager<ApplicationUser> userManager;
        private IBlogService blogService;

        public AdminBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }
        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimsPrincipal);
            return new IndexViewModel
            {
                Blogs = blogService.GetBlogs(applicationUser)
            };
        }
    }
}
