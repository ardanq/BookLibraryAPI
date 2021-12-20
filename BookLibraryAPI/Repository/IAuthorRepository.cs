using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Entities;

namespace BookLibraryAPI.Repository
{
    public interface IAuthorRepository
    {
        Author GetById(int Id);

        void CreateAuthor(string name, string surname);

        void DeleteById(int Id);

        void UpdateAuthor(Author yazar);
    }
}
