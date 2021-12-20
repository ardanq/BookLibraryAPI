using System.ComponentModel.DataAnnotations;

namespace BookLibraryAPI.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        
    }
}
