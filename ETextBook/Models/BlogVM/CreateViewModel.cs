using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ETextBook.Data.Models;
using Microsoft.AspNetCore.Http;

namespace ETextBook.Models.BlogVM
{
    public class CreateViewModel 
    {
        [Required, Display(Name = "Header Image")]
        public IFormFile BlogHeaderImage { get; set; }
        public Blog Blog { get; set; }
    }
}
