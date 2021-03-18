using EloyAhora.BLL;
using EloyAhora.DAL.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EloyAhora.Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : Controller
    {
        private ITagService _TagService;

        public TagController(ITagService TagService)
        {
            _TagService = TagService;
        }

        [HttpPost]
        public async Task<IActionResult> PostTag(Tags Tag)
        {
            return await _TagService.PostTag(Tag);
        }

        [HttpDelete("{id}")]
        public void DeleteTag(string id)
        {
            _TagService.DeleteTag(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTag(string id, [FromBody] Tags Tag)
        {
            return await _TagService.UpdateTag(Tag, id);
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetProducts()
        {
            return await _TagService.GetTag();
        }


    }
}
