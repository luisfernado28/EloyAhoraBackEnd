using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public interface IProductService
    {
        Task<IActionResult> PostProduct(Product Product);

        Product GetProduct(int id);

        Product GetProduct(string email);

        List<Product> GetAllProducts();

        Task<IActionResult> UpdateProduct(Product Product, string id);

        void DeleteProduct(string id);
    }
}
