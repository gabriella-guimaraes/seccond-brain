using System;
using System.Collections.Generic;

namespace second_brain.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        public virtual IEnumerable<Reminder> Reminders { get; set; }
    }
}
