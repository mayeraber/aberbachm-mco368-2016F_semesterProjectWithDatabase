using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    class StoreContext : DbContext
    {
       /* public StoreContext() : base()
        {
            Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<StoreContext>());
        }*/

        //public DbSet<Store> Str;
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
