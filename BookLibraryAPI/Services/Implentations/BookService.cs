using AutoMapper;
using BookLibraryAPI.Models.DTOs;
using BookLibraryAPI.Models.Entities;
using BookLibraryAPI.Repository;

namespace BookLibraryAPI.Services.Implentations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public void CreateBook(BookDto bookdto)
        {
            var mappedModel = _mapper.Map<Book>(bookdto);
            _bookRepository.CreateBook(mappedModel);
        }
    }
}
