using System;

namespace second_brain.Domain.Entities
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
