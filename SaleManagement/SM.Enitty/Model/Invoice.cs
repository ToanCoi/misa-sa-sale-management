using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Model
{
    public class Invoice
    {
        public Guid invoice_id { get; set; }
        public Guid customer_id { get; set; }
        public int payment_type { get; set; }

    }
}
