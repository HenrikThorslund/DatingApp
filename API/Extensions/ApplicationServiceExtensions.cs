using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
             services.AddScoped<Interfaces.ITokenService, TokenService>();
            services.AddDbContext<DataContext>(optionsAction=>
            {
                optionsAction.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;


        }
        
    }
}