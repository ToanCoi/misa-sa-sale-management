using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Model
{
    public class InwardItem
    {
        public Guid inward_item_id { get; set; }
        public Guid product_id { get; set; }
        public Guid warehouse_id { get; set; }
        public decimal warehouse_price { get; set; }
        public int quantity { get; set; }
    }
}
