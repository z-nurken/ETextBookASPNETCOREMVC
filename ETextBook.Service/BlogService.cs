using ETextBook.Data;
using ETextBook.Data.Models;
using ETextBook.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETextBook.Service
{
    public class BlogService: IBlogService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public BlogService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<Blog> Add(Blog blog)
        {
            applicationDbContext.Add(blog);
            await applicationDbContext.SaveChangesAsync();

            return blog;
        }
    }
}
