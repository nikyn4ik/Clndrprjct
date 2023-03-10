using Clndrprjct.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clndrprjct.Data
{
    public interface IReminderRepository
    {
        Task<Reminder> GetReminderByIdAsync(int id);
        Task<IEnumerable<Reminder>> GetRemindersByUserIdAsync(int userId);
        Task AddReminderAsync(Reminder reminder);
        Task UpdateReminderAsync(Reminder reminder);
        Task DeleteReminderAsync(Reminder reminder);
    }
}
