using Microsoft.EntityFrameworkCore;
using TaskMgmService.Models;

namespace TaskMgmService.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly TaskMgmDBContext _db;
        public UsersRepository(TaskMgmDBContext taskMgmDBContext)
        {
            _db = taskMgmDBContext;
        }

        public async Task<List<User>> GetUsers()
        {
            if (_db != null)
                return await _db.Users.ToListAsync();
            return null;
        }

        public async Task<User> GetUsersById(int Id)
        {
            if (_db != null)
                return await _db.Users.FirstOrDefaultAsync(x => x.UserId == Id);
            return null;
        }

        public async Task<int> AddUser(User user)
        {
            if (_db != null)
            {
                _db.Users.Add(user);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<int> UpdateUser(User user)
        {
            if (_db != null)
            {
                _db.Users.Update(user);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<int> DeleteUser(int Id)
        {
            if (_db != null)
            {
                var data = await _db.Users.FirstOrDefaultAsync(x => x.UserId == Id);
                if (data != null)
                {
                    _db.Users.Remove(data);
                    return await _db.SaveChangesAsync();
                }
            }
            return 0;
        }
    }
}
