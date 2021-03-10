using Ecommerce.Models.Product;
using Ecommerce.Repositories;
using Ecommerce.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Train_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("test")]
        public IActionResult GetDetail()
        {
            var response = new BaseResponse();
            var detail = new ProductDetailModel()
            {
                id = 1,
                productName= "Iohone 11"
            };
            var city = new ProductRepository();
            var tlll = city.GetProductName(5558);
            return Ok(tlll);
        }
    }
}
