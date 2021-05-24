using ClassProject.Application.Interface;
using ClassProject.Application.Models.Product;
using ClassProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Application.Repository
{
    public class ProductRepo : IProductRepo
    {
        private IRepository<Products> _repository;

        public ProductRepo(IRepository<Products> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<ProductResponse>> GetProductAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> GetProductById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
