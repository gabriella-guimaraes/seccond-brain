using System.ComponentModel.DataAnnotations;

namespace second_brain.API.ViewModel
{
    public class ReminderViewModel
    {
        [Key]
        public int ReminderId { get; set; }

        [Required(ErrorMessage = "Please, write down a title")]
        [MaxLength(150, ErrorMessage = "Max Lenght {0} characters")]
        [MinLength(5, ErrorMessage = "The title must have at least {0} characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, write down a description")]
        [MaxLength(340, ErrorMessage = "Max Lenght {0} characters")]
        [MinLength(16, ErrorMessage = "The description must have at least {0} characters")]
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
