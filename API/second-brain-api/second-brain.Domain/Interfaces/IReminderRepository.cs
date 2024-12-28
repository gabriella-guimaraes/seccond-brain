using second_brain.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace second_brain.Domain.Interfaces
{
    public interface IReminderRepository : IRepositoryBase<Reminder>
    {
        IEnumerable<Reminder> SearchByTitle(string title);
    }
}
