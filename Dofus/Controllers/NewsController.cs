using Dofus.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dofus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        private readonly INewsServices _newsServices;

        public NewsController(INewsServices newsServices)
        {
            _newsServices = newsServices;
        }

        // GET: api/news
        [HttpGet]
        public async Task<ActionResult> GetAllNews()
        {
            var newsItems = await _newsServices.GetAllAsync();
            return Ok(newsItems);
        }

        // GET: api/news/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetNews(int id)
        {
            var newsItem = await _newsServices.GetByIdAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }
            return Ok(newsItem);
        }

        // POST: api/news
        [HttpPost]
        public async Task<ActionResult> AddNews([FromBody] NewsDto newsDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdNews = await _newsServices.AddAsync(newsDto);
            return CreatedAtAction(nameof(GetNews), new { id = createdNews.Id }, createdNews);
        }

        // PUT: api/news/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNews(int id, [FromBody] NewsDto newsDto)
        {
            if (id != newsDto.Id)
            {
                return BadRequest();
            }

            await _newsServices.UpdateAsync(newsDto);
            return NoContent();
        }

        // DELETE: api/news/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNews(int id)
        {
            await _newsServices.RemoveAsync(id);
            return NoContent();
        }
    }
}
