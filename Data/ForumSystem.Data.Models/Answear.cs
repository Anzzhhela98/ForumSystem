namespace ForumSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;

    public class Answear : BaseModel<int>
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        [Display(Name = "Answer")]
        [Required(ErrorMessage = "The answer is required")]
        public string Title { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
