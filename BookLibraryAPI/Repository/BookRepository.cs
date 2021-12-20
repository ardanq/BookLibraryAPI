using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Book GetById(int Id)
        {
            var data= _context.Book.Find(Id);
            return data;
        }

        public void CreateBook(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
        }

        public void DeleteById(int Id)
        {
            var book = _context.Book.Find(Id);

            _context.Book.Remove(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book kitapObj)
        {
            _context.Update(kitapObj);
            _context.SaveChanges();
        }

        
    }
}
