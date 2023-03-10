using EcommerceTest.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceTest.Persistance
{
    public static class ServiceRegistiration 
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }

    }
}
