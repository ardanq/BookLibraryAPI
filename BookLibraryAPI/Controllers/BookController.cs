using BookLibraryAPI.Models.DTOs;
using BookLibraryAPI.Repository;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpPost]
        public void CreateBook(BookDto bookDto)
        {
            _bookService.CreateBook(bookDto);
        }
    }
}
