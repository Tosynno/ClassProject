using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Domain.Entities
{
    public class Order 
    {
        public int Id { get; set; }
        public double ProductPrice { get; set; }
        public double CurrentPrice { get; set; }
        public int NumberofItems { get; set; }
        public string Status { get; set; }
        public double TotalAmount { get; set; }
        public long ProductId { get; set; }
        public virtual Products Product { get; set; }
        public long CustomerId { get; set; }
        public virtual User user { get; set; }
        public ICollection<Payment> payment { get; set; }

    }
}
