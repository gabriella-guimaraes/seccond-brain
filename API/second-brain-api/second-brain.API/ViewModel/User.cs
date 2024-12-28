using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace second_brain.API.ViewModel
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please, write down a username")]
        [MaxLength(120, ErrorMessage = "Max Lenght {0} characters")]
        [MinLength(3, ErrorMessage = "Your username must have at least {0} characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please, write down your name")]
        [MaxLength(150, ErrorMessage = "Max Lenght {0} characters")]
        [MinLength(3, ErrorMessage = "Your name must have at least {0} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, write down your name")]
        [MaxLength(100, ErrorMessage = "Max Lenght {0} characters")]
        [EmailAddress(ErrorMessage = "Please, write down a valid E-mail")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, write down the password")]
        [MaxLength(16, ErrorMessage = "Max Lenght {0} characters")]
        [MinLength(8, ErrorMessage = "Your password must have at least {0} characters")]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        //public virtual IEnumerable<Reminder> Reminders { get; set; }
    }
}
