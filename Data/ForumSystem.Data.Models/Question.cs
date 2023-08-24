namespace ForumSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Question")]
        [Required(ErrorMessage = "The question is required")]
        public string Title { get; set; }

        public int Likes { get; set; }

        public bool IsAnsweared { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        public string CreatedByUserId { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        //[Required]
        //public int CategoryId { get; set; }

        //public Category Category { get; set; }

        public ICollection<Answear> Answears { get; set; }
               = new HashSet<Answear>();
    }
}
