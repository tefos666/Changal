using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changal.Domain.Entities
{
    public class Order
    {

        public int Id { get; set; }
        public string OrderDate { get; set; }
        public long CustomerId { get; set; }
        public List<Food> Foods { get; set; }
        public long Price { get; set; }
        public long TotalDiscount { get; set; } = 0;
        public long TotalTax { get; set; }
        public long Deliveryfee { get; set; }
        public long TotalPrice { get; set; }

    }
}
