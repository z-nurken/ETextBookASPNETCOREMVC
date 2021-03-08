using ETextBook.Authorization;
using ETextBook.BusinessManagers;
using ETextBook.BusinessManagers.Interfaces;
using ETextBook.Data;
using ETextBook.Data.Models;
using ETextBook.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace ETextBook.Configuration
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)  // отключил подтверждение аккаунта
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();  //AddRazorRuntimeCompilation - в режиме рантаима можем изменить динамический html райзор пейджа
            services.AddRazorPages();

            services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IPostBusinessManager, PostBusinessManager>();
            services.AddScoped<IAdminBusinessManager,AdminBusinessManager>();


            services.AddScoped<IPostService, Service.PostService>();

        }

        public static void AddCustomAuthorization(this IServiceCollection services)
        {
            //services.AddSingleton<IAuthorizationHandler, BlogAuthorizationHandler>();
            services.AddTransient<IAuthorizationHandler, PostAuthorizationHandler>();
        }
    }
}
