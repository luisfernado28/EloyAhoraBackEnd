using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.DAL
{
    public interface IProductRepository
    {
        Task<IActionResult> InsertProductAsync(Product product);
        Task<IActionResult> SelectProducts();
        Task<IActionResult> UpdateProduct(string id, Product product);
        void DeleteProduct(string id);
    }
}
