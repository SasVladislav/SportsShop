using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SportsStore.Infrastructure
{
    public class StoreIdentityDbContext:IdentityDbContext<StoreUser>
    {
        public StoreIdentityDbContext():base("SportStoreIdentityDb")
        {
            Database.SetInitializer<StoreIdentityDbContext>(new
                StoreIdentityDbInitializer());
        }
        public static StoreIdentityDbContext Create()
        {
            return new StoreIdentityDbContext();
        }
    }
}