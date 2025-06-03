using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly FunewsManagementContext _context;
        public NewsArticleRepository(FunewsManagementContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddNewsArticleAsync(NewsArticle newsArticle)
        {
            await _context.NewsArticles.AddAsync(newsArticle);
            await _context.SaveChangesAsync(); // Ensure changes are saved to the database
        }

        public Task DeleteNewsArticleAsync(int id)
        {
            var newsArticle = _context.NewsArticles.Find(id);
            if (newsArticle != null)
            {
                _context.NewsArticles.Remove(newsArticle);
                return _context.SaveChangesAsync(); // Ensure changes are saved to the database
            }
            else
            {
                throw new KeyNotFoundException($"News article with ID {id} not found.");
            }
        }

        public async Task<IEnumerable<NewsArticle>> GetAllNewsArticlesAsync()
        {
            return await _context.NewsArticles.ToListAsync(); // Assuming you have a DbSet<NewsArticle> in your FunewsManagementContext
        }

        public async Task<NewsArticle> GetNewsArticleByIdAsync(int id)
        {
            return await _context.NewsArticles.FindAsync(id);
        }

        public Task UpdateNewsArticleAsync(NewsArticle newsArticle)
        {
            _context.NewsArticles.Update(newsArticle);
            return _context.SaveChangesAsync(); // Ensure changes are saved to the database
        }
    }
}
