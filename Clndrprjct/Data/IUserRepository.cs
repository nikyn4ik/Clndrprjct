using Clndrprjct.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clndrprjct.Data
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        bool UserExists(int id);
    }
}
