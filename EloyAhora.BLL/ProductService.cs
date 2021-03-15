﻿using EloyAhora.DAL;
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

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> PostProduct(Product Product)
        {
            return await _databaseRepository.InsertProductAsync(Product);
        }

        public Product UpdateProduct(Product Product, int id)
        {
            throw new NotImplementedException();
        }

        
        Task<IActionResult> IProductService.UpdateProduct(Product Product, int id)
        {
            throw new NotImplementedException();
        }
    }
}
