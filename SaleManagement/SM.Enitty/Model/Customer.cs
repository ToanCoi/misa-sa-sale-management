using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Model
{
    public class Customer
    {
        public Guid customer_id { get; set; }
        public string name { get; set; }
        public string? address { get; set; }
        public string phone { get; set; }
        public string? email { get; set; }
    }
}
