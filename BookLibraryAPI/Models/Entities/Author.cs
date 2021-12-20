using System.ComponentModel.DataAnnotations;

namespace BookLibraryAPI.Models.Entities
{
    public class Author : BaseEntity
    {

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }
    }
}
