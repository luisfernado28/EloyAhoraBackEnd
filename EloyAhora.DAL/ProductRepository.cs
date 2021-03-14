using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace EloyAhora.DAL
{
    public class ProductRepository : IProductRepository
    {
        private static String connectionString = "";
        //private static String connectionString = Environment.GetEnvironmentVariable("SQL_STRING");
        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> InsertProductAsync(Product product)
        {

            try
            {
                var client = new MongoClient(Environment.GetEnvironmentVariable("mongodb://localhost:27017"));
                var database = client.GetDatabase("eloyahora");
                var collection = database.GetCollection<Product>("product");

                await collection.InsertOneAsync(product);
            }
            catch (Exception)
            {
                throw new Exception("fail to fetch");
            }
            return new OkObjectResult(product);
        }

        public Product SelectProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }

      
    }
}
