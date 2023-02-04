using ContactPro.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            // get instance of the application db context
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();
            // equivalent to update-database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
