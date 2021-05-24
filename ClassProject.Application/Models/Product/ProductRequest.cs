using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Models.Product
{
    public class ProductRequest
    {
        public string ProductName { get; set; }
        public byte[] ImageUrl { get; set; }
        public string Description { get; set; }
        public double ProductPrice { get; set; }
    }
}
