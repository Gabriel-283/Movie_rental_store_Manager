using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieRentalStoreManager.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalStoreManager.Data.Extensions
{
    public static class MigrationExtension
    {
        public static void MigrateInitializer(this IApplicationBuilder app)
        {
            try
            {
                using (var serviceScope = app.ApplicationServices.CreateScope())
                {
                    var serviceDb = serviceScope.ServiceProvider.GetService<AppDbContext>();

                    serviceDb.Database.Migrate();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
