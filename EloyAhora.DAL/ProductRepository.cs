using EloyAhora.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Product InsertProduct(Product users)
        {
            throw new NotImplementedException();
        }

        public Product SelectProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(int id, Product user)
        {
            throw new NotImplementedException();
        }
    }
}
