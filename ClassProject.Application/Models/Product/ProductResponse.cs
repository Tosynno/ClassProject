using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Models.Product
{
    public class ProductResponse
    {
        public string ProductName { get; set; }
        public byte[] ImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string SellerName { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}
