using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateAuthor(string name, string surname)
        {
            Author yazarObj = new()
            {
                Name = name,
                Surname = surname
            };

            _context.Author.Add(yazarObj);
            _context.SaveChanges();
        }

        public void DeleteById(int Id)
        {
            var deletedAuthor = _context.Author.Find(Id);

            _context.Author.Remove(deletedAuthor);
            _context.SaveChanges();
                
        }

        public Author GetById(int Id)
        {
            var data = _context.Author.Find(Id);
            
            return data;
        }

        public void UpdateAuthor(Author yazarObj)
        {
            _context.Author.Update(yazarObj);
            _context.SaveChanges();
        }
    }
}
