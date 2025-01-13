using second_brain.Domain.Entities;
using System;
using System.Collections.Generic;

namespace second_brain.Domain.Interfaces.Services
{
    public interface IReminderService : IServiceBase<Reminder>
    {
        IEnumerable<Reminder> SearchByTitle(string title);
    }
}
