using EloyAhora.BLL;
using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EloyAhora.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productservice;

        public ProductController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(Product product)
        {
            return await _productservice.PostProduct(product);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(string id)
        {
            _productservice.DeleteProduct(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, [FromBody] Product product)
        {
            return await _productservice.UpdateProduct(product,id);
        }
    }
}
