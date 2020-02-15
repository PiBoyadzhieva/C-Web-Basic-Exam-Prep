using Microsoft.EntityFrameworkCore;

namespace Andreys.App
{
    using Data;
    using SIS.HTTP;
    using SIS.MvcFramework;
    using System.Collections.Generic;
    using Services;

    public class Startup : IMvcApplication
    {
        public void Configure(IList<Route> serverRoutingTable)
        {
            //using (var db = new AndreysDbContext())
            //{
            //    db.Database.EnsureCreated();
            //}
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<IProductsService, ProductsService>();
        }
    }
}
