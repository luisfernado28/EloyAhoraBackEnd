using EloyAhora.DAL.Models;
using EloyAhora.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _userDB;

        public UserRepository(IEloyAhoraDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _userDB = database.GetCollection<User>(settings.UserCollectionName);

        }
        public async void DeleteUser(string id)
        {
            try
            {
                await _userDB.DeleteOneAsync(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IActionResult> InsertUserAsync(User User)
        {
            try
            {
                await _userDB.InsertOneAsync(User);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult(User);
        }

        public async Task<IActionResult> SelectUsers()
        {
            List<User> users = new List<User>();
            try
            {
                var filter = FilterDefinition<User>.Empty;
                users = _userDB.FindAsync(filter).Result.ToList();
                return new OkObjectResult(users);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IActionResult> UpdateUser(string id, User User)
        {
            try
            {
                var existingProduct = await _userDB.Find(x => x.Id == id).FirstOrDefaultAsync();
                var newUser = replaceProduct(id, User);
                await _userDB.ReplaceOneAsync(x => x.Id == id, newUser);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult(User);
        }

        static public User replaceProduct(string id, User user)
        {
            user.Id = id;
            return user;
        }

    }
}
