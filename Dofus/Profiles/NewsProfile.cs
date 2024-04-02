using AutoMapper;
using Dofus.Models;
using System.Net;

namespace Dofus.Profiles
{
    public class NewsProfile :Profile
    {
        public NewsProfile()
        {
            CreateMap<News, NewsDto>().ReverseMap();
        }
    }
}
