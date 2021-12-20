using AutoMapper;
using BookLibraryAPI.Models.DTOs;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Utility.Mapper
{
    public class RequestProfile : Profile
    {
        public RequestProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<AuthorDto, Author>();
        }
    }
}
