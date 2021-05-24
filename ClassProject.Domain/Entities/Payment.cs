using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public double Amount { get; set; }
        public int[] OrderId { get; set; }
        public virtual Order order { get; set; }
        public long CustomerId { get; set; }
        public virtual User user { get; set; }

    }
}
