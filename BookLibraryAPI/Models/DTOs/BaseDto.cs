namespace BookLibraryAPI.Models.DTOs
{
    public class BaseDto
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
