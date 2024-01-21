using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkDemo.Web.Business;
using UnitOfWorkDemo.Web.DAL.Repositories;
using UnitOfWorkDemo.Web.Business.Interfaces;
using UnitOfWorkDemo.Web.DAL.Repositories.Interfaces;

namespace UnitOfWorkDemo.Web.DAL
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextClass>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();

            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IBlogManager, BlogManager>();

            return services;
        }
    }
}
