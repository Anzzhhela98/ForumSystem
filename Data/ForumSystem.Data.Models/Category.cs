namespace ForumSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
            = new HashSet<SubCategory>();
    }
}
