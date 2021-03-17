using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public interface IUserService
    {
        Task<IActionResult> PostUser(User User);

        Task<IActionResult> GetUser();

        Task<IActionResult> UpdateUser(User User, string id);

        void DeleteUser(string id);
    }
}
