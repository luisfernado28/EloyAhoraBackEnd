using EloyAhora.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EloyAhora.BLL
{
    public interface ITagService
    {
        Task<IActionResult> PostTag(Tags Tag);

        Task<IActionResult> GetTag();

        Task<IActionResult> UpdateTag(Tags Tag, string id);

        void DeleteTag(string id);
    }
}
