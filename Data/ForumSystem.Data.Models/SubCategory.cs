namespace ForumSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SubCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Question> Questions { get; set; }
        = new HashSet<Question>();
    }
}
