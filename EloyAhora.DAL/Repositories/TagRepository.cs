using EloyAhora.DAL.Models;
using EloyAhora.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EloyAhora.DAL
{
    public class TagRepository : ITagRepository
    {
        private readonly IMongoCollection<Tags> _TagDB;

        public TagRepository(IEloyAhoraDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _TagDB = database.GetCollection<Tags>(settings.TagsCollectionName);

        }
        public async void DeleteTag(string id)
        {
            try
            {
                await _TagDB.DeleteOneAsync(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IActionResult> InsertTagAsync(Tags tag)
        {
            try
            {
                await _TagDB.InsertOneAsync(tag);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult(tag);
        }

        public async Task<IActionResult> SelectTags()
        {
            List<Tags> Tags = new List<Tags>();
            try
            {
                var filter = FilterDefinition<Tags>.Empty;
                Tags = _TagDB.FindAsync(filter).Result.ToList();
                return new OkObjectResult(Tags);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IActionResult> UpdateTag(string id, Tags tag)
        {
            try
            {
                var existingProduct = await _TagDB.Find(x => x.Id == id).FirstOrDefaultAsync();
                var newTag = replaceProduct(id, tag);
                await _TagDB.ReplaceOneAsync(x => x.Id == id, newTag);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return new OkObjectResult(tag);
        }

        static public Tags replaceProduct(string id, Tags tag)
        {
            tag.Id = id;
            return tag;
        }

    }
}
