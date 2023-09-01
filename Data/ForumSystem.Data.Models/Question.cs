namespace ForumSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;

    public class Question : BaseModel<int>
    {
        [MaxLength(50)]
        [Display(Name = "Question")]
        [Required(ErrorMessage = "The question is required")]
        public string Title { get; set; }

        public int Likes { get; set; }

        public bool IsAnsweared { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }



        public ICollection<Answear> Answears { get; set; }
               = new HashSet<Answear>();
    }
}
