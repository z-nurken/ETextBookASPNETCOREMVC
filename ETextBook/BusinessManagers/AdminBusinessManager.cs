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
        private IPostService postService;

        public AdminBusinessManager(UserManager<ApplicationUser> userManager, IPostService postService)
        {
            this.userManager = userManager;
            this.postService = postService;
        }
        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimsPrincipal);
            return new IndexViewModel
            {
                Posts = postService.GetPosts(applicationUser)
            };
        }
    }
}
