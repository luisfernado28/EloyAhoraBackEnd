using EloyAhora.DAL.Models;
using EloyAhora.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace EloyAhora.DAL
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _product;

        public ProductRepository(IEloyAhoraDatabaseSettings  settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _product= database.GetCollection<Product>(settings.ProductsCollectionName);
        }

        public async void DeleteProduct(string id)
        {
            try
            {
                await _product.DeleteOneAsync(evnt => evnt.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IActionResult> InsertProductAsync(Product product)
        {
            try
            {
                await _product.InsertOneAsync(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult(product);
        }

        public Product SelectProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> UpdateProduct(string id, Product product)
        {
            try
            {
                var existingProduct = await _product.Find(x => x.Id == id).FirstOrDefaultAsync();
                var newProduct = replaceProduct(id, product);
                await _product.ReplaceOneAsync(x => x.Id == id, newProduct);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult( product);
        }

        static public Product replaceProduct(string id, Product product)
        {
            product.Id = id;
            return product;
        }
      
    }
}
