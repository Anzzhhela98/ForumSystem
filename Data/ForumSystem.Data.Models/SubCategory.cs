namespace ForumSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;

    public class SubCategory : BaseModel<int>
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
