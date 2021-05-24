using ClassProject.Application.Models.Product;
using ClassProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Interface
{
    public interface IProductRepo 
    {
        Task<IEnumerable<ProductResponse>> GetProductAll();
        Task<ProductResponse> GetProductById(int Id);
    }
}
