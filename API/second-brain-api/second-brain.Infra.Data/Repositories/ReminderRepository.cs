using second_brain.Domain.Entities;
using second_brain.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace second_brain.Infra.Data.Repositories
{
    public class ReminderRepository : RepositoryBase<Reminder>, IReminderRepository
    {
        public IEnumerable<Reminder> SearchByTitle(string title)
        {
            return Db.Reminders.Where(r => r.Title == title).ToList();
        }
    }
}
