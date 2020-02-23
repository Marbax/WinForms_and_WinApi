using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsCatalog
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Count { get; set; }

        public int Category_Id { get; set; }

        public int Provider_Id { get; set; }

        public virtual Category Category { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
