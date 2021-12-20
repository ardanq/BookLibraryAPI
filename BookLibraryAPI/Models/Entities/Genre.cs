using System.ComponentModel.DataAnnotations;

namespace BookLibraryAPI.Models.Entities
{
    public class Genre : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Summary { get; set; }
    }
}
