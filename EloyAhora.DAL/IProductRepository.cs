using EloyAhora.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EloyAhora.DAL
{
    public interface IProductRepository
    {
        Product InsertProduct(Product users);
        Product SelectProduct(int id);
        //List<User> SelectAllProducts();
        Product UpdateProduct(int id, Product user);
        void DeleteProduct(int id);
    }
}
