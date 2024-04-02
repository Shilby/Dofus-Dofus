using AutoMapper;
using Dofus.Models;
using Dofus.Repository.Interfaces;
using Dofus.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dofus.Services
{
    public class NewsServices : INewsServices
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public NewsServices(INewsRepository newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }

        public async Task<NewsDto> AddAsync(NewsDto newsDto)
        {
            if (newsDto == null)
            {
                // Consider how you want to handle null inputs
                return null;
            }
            var news = _mapper.Map<News>(newsDto);
            await _newsRepository.AddNewsAsync(news);
            return _mapper.Map<NewsDto>(news);
        }

        public async Task<IEnumerable<NewsDto>> GetAllAsync()
        {
            var newsItems = await _newsRepository.GetAllNewsAsync();
            return _mapper.Map<IEnumerable<NewsDto>>(newsItems);
        }

        public async Task<NewsDto> GetByIdAsync(int id)
        {
            var news = await _newsRepository.GetNewsByIdAsync(id);
            return _mapper.Map<NewsDto>(news);
        }

        public async Task RemoveAsync(int id)
        {
            await _newsRepository.DeleteNewsAsync(id);
        }

        public async Task UpdateAsync(NewsDto newsDto)
        {
            var news = _mapper.Map<News>(newsDto);
            await _newsRepository.UpdateNewsAsync(news);
        }
    }
}
