using ETextBook.Models.AdminVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ETextBook.BusinessManagers.Interfaces
{
    public interface IAdminBusinessManager
    {
        Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal);
    }
}
