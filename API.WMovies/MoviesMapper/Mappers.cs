using API.WMovies.DAL.Models;
using API.WMovies.DAL.Models.Dtos;
using AutoMapper;

namespace API.WMovies.MoviesMapper
{
    public class Mappers: Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
