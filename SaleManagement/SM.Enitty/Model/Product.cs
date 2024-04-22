using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Model
{
    public class Product
    {
        public Guid product_id { get; set; }
        public string product_name { get; set; }

        public string? description { get; set; }

        public int category { get; set; }
    }
}
