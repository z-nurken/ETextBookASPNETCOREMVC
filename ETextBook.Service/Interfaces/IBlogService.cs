using ETextBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETextBook.Service.Interfaces
{
    public interface IBlogService
    {
        Blog GetBlog(int blogId);
        IEnumerable<Blog> GetBlogs(string searchString);
        IEnumerable<Blog> GetBlogs(ApplicationUser applicationUser);
        Task<Blog> Add(Blog blog);
        Task<Blog> Update(Blog blog);
    }
}
