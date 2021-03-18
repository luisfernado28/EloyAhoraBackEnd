using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EloyAhora.DAL.Models;

namespace EloyAhora.DAL
{
    public interface ITagRepository
    {
        Task<IActionResult> InsertTagAsync(Tags Tag);
        Task<IActionResult> SelectTags();
        Task<IActionResult> UpdateTag(string id, Tags Tag);
        void DeleteTag(string id);
    }
}
