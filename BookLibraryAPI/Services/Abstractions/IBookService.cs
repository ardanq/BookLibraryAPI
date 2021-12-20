using BookLibraryAPI.Models.DTOs;

namespace BookLibraryAPI.Services
{
    public interface IBookService
    {
        void CreateBook(BookDto bookdto);
    }
}
