using EloyAhora.DAL;
using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public class UserService : IUserService
    {
        private IUserRepository _databaseRepository;

        public UserService(IUserRepository userRepositoty)
        {
            _databaseRepository = userRepositoty;
        }

        public void DeleteUser(string id)
        {
            _databaseRepository.DeleteUser(id);
        }

        public Task<IActionResult> GetUser()
        {
           return _databaseRepository.SelectUsers();
        }

        public async Task<IActionResult> PostUser(User User)
        {
            return await _databaseRepository.InsertUserAsync(User); 
        }

        public async Task<IActionResult> UpdateUser(User User, string id)
        {
            return await _databaseRepository.UpdateUser(id, User);
        }
    }
}
