using TaskMgmService.Models;

namespace TaskMgmService.Repository
{
    public interface IUsersRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUsersById(int Id);

        Task<int> AddUser(User user);

        Task<int> UpdateUser(User user);

        Task<int> DeleteUser(int Id);
    }
}
