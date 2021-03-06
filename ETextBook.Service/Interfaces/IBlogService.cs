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
        Task<Blog> Add(Blog blog);

    }
}
