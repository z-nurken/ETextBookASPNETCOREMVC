﻿using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Data.Models;
using ETextBook.Models.BlogVM;
using ETextBook.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETextBook.BusinessManagers
{
    public class BlogBusinessManager : IBlogBusinessManager
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IBlogService blogService;

        public BlogBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }

        public async Task<Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal)
        {
            Blog blog = createBlogViewModel.Blog;

            blog.Creator = await userManager.GetUserAsync(claimsPrincipal);
            blog.CreatedOn = DateTime.Now;

            //Blog blog = new Blog
            //{
            //    Creator = await userManager.GetUserAsync(claimsPrincipal),
            //    CreatedOn = DateTime.Now,

            //};

            return await blogService.Add(blog);
        }
    }
}
