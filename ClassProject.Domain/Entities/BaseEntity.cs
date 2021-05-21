using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Domain.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; } 
        public int RoleId { get; set; }
        public string Token { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
