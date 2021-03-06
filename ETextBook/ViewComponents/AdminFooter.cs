﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ETextBook.ViewComponents
{
    public class AdminFooter: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() => { return View(); });
        }
    }
}
