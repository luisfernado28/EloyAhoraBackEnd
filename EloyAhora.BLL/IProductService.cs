using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public interface IProductService
    {
        Task<IActionResult> PostProduct(Product Product);

        Task<IActionResult> GetProduct();

        Task<IActionResult> UpdateProduct(Product Product, string id);

        void DeleteProduct(string id);
    }
}
