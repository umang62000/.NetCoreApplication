using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Model
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Notes { get; set; }
    }
}
