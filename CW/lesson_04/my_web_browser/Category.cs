
using System.Collections.Generic;

namespace my_web_browser
{
    class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// For one to many relationships
        /// </summary>
        public virtual List<Site> Sites { get; set; }


    }
}
