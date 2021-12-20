namespace BookLibraryAPI.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
    }
}
