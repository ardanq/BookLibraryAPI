namespace BookLibraryAPI.Models.Entities
{
    public class BookAuthor : BaseEntity
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
    }
}
