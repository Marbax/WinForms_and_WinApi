using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace my_web_browser
{
    class DataManager : DbContext
    {
        /// <summary>
        /// using "name" from ```app.config db``` connection name
        /// </summary>
        public DataManager() : base("Default") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Site> Sites { get; set; }

    }
}
