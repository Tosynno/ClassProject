using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Passwordsalt { get; set; }
        public int ApprovalSeller { get; set; }
        public DateTime? BirthDay { get; set; }

        public ICollection<Order> orders { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Products> createdUser { get; set; }
        public ICollection<Products> approvalUser { get; set; }

    }
}
