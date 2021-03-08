using ETextBook.Data.Models;
using ETextBook.Models.BlogVM;
using ETextBook.Models.HomeVM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETextBook.BusinessManagers.Interfaces
{
    public interface IBlogBusinessManager
    {
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<Blog> CreateBlog(CreateViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdateBlog(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
    }
}
