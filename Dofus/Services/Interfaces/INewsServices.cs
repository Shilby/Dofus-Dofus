using Dofus.Models;
using System.Linq.Expressions;

namespace Dofus.Services.Interfaces
{
    public interface INewsServices
    {
        Task<NewsDto> GetByIdAsync(int id);
        Task<IEnumerable<NewsDto>> GetAllAsync();
        Task<NewsDto> AddAsync(NewsDto newsDto);
        Task UpdateAsync(NewsDto newsDto);
        Task RemoveAsync(int id);
    }
}
