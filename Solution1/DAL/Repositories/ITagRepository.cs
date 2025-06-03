using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<string>> GetAllTagsAsync();
        Task<string> GetTagByIdAsync(int id);
        Task AddTagAsync(string tag);
        Task UpdateTagAsync(string tag);
        Task DeleteTagAsync(int id);
    }
}
