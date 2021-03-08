using ETextBook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETextBook.Models.AdminVM
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
