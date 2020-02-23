using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GoodsCatalog
{
    class DataManager : DbContext
    {
        public DataManager() : base("BaseDB") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
