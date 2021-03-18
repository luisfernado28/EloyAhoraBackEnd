using EloyAhora.DAL;
using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public class ProductService : IProductService
    {
        private IProductRepository _databaseRepository;

        public ProductService(IProductRepository usersRepository)
        {
            _databaseRepository = usersRepository;
        }

        public void DeleteProduct(string id)
        {
            _databaseRepository.DeleteProduct(id);
        }

        public async Task<IActionResult> GetProduct()
        {
            return await _databaseRepository.SelectProducts();
        }

        public async Task<IActionResult> PostProduct(Product Product)
        {
            return await _databaseRepository.InsertProductAsync(Product);
        }
        
        public async Task<IActionResult> UpdateProduct(Product Product, string id)
        {
            return await _databaseRepository.UpdateProduct(id, Product);
        }
    }
}
