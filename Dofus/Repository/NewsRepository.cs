using Dofus.Data;
using Dofus.Models;
using Dofus.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dofus.Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly DofusContext _context;

        public NewsRepository(DofusContext context)
        {
            _context = context;
        }

       
        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _context.NewsItems.ToListAsync();
        }

        
        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _context.NewsItems.FindAsync(id);
        }

      
        public async Task<News> AddNewsAsync(News news)
        {
             _context.NewsItems.Add(news);
            await _context.SaveChangesAsync();
            return news;
        }

       
        public async Task UpdateNewsAsync(News news)
        {
            _context.Entry(news).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

       
        public async Task DeleteNewsAsync(int id)
        {
            var news = await _context.NewsItems.FindAsync(id);
            if (news != null)
            {
                _context.NewsItems.Remove(news);
                await _context.SaveChangesAsync();
            }
        }
    }
}
