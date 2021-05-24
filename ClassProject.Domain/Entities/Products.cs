using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Domain.Entities
{
    public class Products : BaseEntity
    {
       
        public string ProductName { get; set; }
        public byte[] ImageUrl { get; set; }
        public string Description { get; set; }
        public double ProductPrice { get; set; }
       // public double CurrentPrice { get; set; }
        public long CreatedBy { get; set; }
        public virtual User CreatedUser { get; set; }
        public long ApprovalBy { get; set; }
        public virtual User ApprovalUser { get; set; }
        public ICollection<Order> order { get; set; }
    }
}
