using ClassProject.Application.Interface;
using ClassProject.Application.Models.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProject.Presentation.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ProductController : BaseController
    {
        //protected IProductRepo _ProductRepo;

        //public ProductController(IProductRepo productRepo)
        //{
        //    _ProductRepo = productRepo;
        //}

        [Route("GetProduct")]
        [HttpGet]
        public async Task<ProductResponse> Product()
        {
            ProductResponse response = new ProductResponse();
            response.ResponseCode = "00";
            response.ResponseDescription = "Succesfully";
            return await Task.FromResult(response);
        }
    }
}
