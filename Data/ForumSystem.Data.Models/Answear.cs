using ForumSystem.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ForumSystem.Data.Models
{
    public class Answear : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Display(Name = "Answer")]
        [Required(ErrorMessage = "The answer is required")]
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
