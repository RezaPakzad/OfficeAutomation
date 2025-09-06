using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeAutomation.Domain.DomainServices;
using OfficeAutomation.Infrastructure.Context;
using OfficeAutomation.Infrastructure.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAutomation.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var cs = configuration.GetConnectionString("DefaultConnection")!;
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(cs));
            services.AddScoped<PasswordConfirmationService>(); // ثبت سرویس
            services.AddScoped<PersonalService>(); // ثبت سرویس
            services.AddScoped<IClientIpService, ClientIpService>();
            services.AddHttpContextAccessor();
            return services;
        }
    }
}
