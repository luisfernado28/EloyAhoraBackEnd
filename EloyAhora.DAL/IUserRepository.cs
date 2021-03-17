using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.DAL
{
    public interface IUserRepository
    {
        Task<IActionResult> InsertUserAsync(User User);
        Task<IActionResult> SelectUsers();
        Task<IActionResult> UpdateUser(string id, User User);
        void DeleteUser(string id);
    }
}
