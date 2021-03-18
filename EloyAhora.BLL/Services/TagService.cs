using EloyAhora.DAL;
using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public class TagService : ITagService
    {
        private ITagRepository _databaseRepository;

        public TagService(ITagRepository TagRepositoty)
        {
            _databaseRepository = TagRepositoty;
        }

        public void DeleteTag(string id)
        {
            _databaseRepository.DeleteTag(id);
        }

        public Task<IActionResult> GetTag()
        {
           return _databaseRepository.SelectTags();
        }

        public async Task<IActionResult> PostTag(Tags Tag)
        {
            return await _databaseRepository.InsertTagAsync(Tag); 
        }

        public async Task<IActionResult> UpdateTag(Tags Tag, string id)
        {
            return await _databaseRepository.UpdateTag(id, Tag);
        }
    }
}
