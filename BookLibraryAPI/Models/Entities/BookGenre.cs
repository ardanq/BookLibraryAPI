namespace BookLibraryAPI.Models.Entities
{
    public class BookGenre : BaseEntity
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}
