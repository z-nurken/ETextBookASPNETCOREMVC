using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ETextBook.Data.Models;
using Microsoft.AspNetCore.Http;

namespace ETextBook.Models.PostVM
{
    public class CreateViewModel 
    {
        [Required, Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}
