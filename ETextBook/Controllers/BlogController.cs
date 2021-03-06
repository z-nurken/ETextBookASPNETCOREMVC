﻿using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Models.BlogVM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETextBook.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogBusinessManager blogBusinessManager;
        public BlogController(IBlogBusinessManager blogBusinessManager)
        {
            this.blogBusinessManager = blogBusinessManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new CreateBlogViewModel());
        } 

        [HttpPost]
        public async Task<IActionResult> Add(CreateBlogViewModel createBlogViewModel)
        {
            await blogBusinessManager.CreateBlog(createBlogViewModel, User);
            return RedirectToAction("Create");
            //return View("Create", createBlogViewModel);
        }
    }
}
