using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes
{
    public class StartUp : IMvcApplication
    {
        public void Configure(IList<Route> routeTable)
        {
            var db = new ApplicationDbContext();
            db.Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }
    }
}
