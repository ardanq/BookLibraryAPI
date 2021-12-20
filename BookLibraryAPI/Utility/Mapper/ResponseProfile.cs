using AutoMapper;
using BookLibraryAPI.Models.DTOs;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Utility.Mapper
{
    public class ResponseProfile:Profile
    {
        public ResponseProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<Author, AuthorDto>();
        }
    }
}
