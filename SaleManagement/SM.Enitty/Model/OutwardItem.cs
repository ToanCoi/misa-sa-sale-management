using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Model
{
    public class OutwardItem
    {
        public Guid outward_item_id { get; set; }
        public Guid invoice_id { get; set; }
        public Guid product_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
}
