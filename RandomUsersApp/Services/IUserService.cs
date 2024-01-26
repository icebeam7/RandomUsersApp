using RandomUsersApp.Models;

namespace RandomUsersApp.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>?> GetUsers();
    }
}
