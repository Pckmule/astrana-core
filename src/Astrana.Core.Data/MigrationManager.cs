using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Data
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.CreateScope();
            using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                appContext.Database.Migrate();
            }

            return webApplication;
        }
    }
}
