using Microsoft.EntityFrameworkCore;
using TaskMgmService.Models;

namespace TaskMgmService.Repository
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly TaskMgmDBContext _db;
        public RegisterRepository(TaskMgmDBContext taskMgmDBContext)
        {
            _db = taskMgmDBContext;
        }

        public async Task<List<Registration>> GetRegistrations()
        {
            if (_db != null)
                return await _db.Registrations.ToListAsync();
            return null;
        }

        public async Task<Registration> GetRegistrationsById(int Id)
        {
            if (_db != null)
                return await _db.Registrations.FirstOrDefaultAsync(x => x.UserId == Id);
            return null;
        }

        public async Task<int> AddRegistration(Registration registration)
        {
            if (_db != null)
            {
                _db.Registrations.Add(registration);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<int> UpdateRegistration(Registration registration)
        {
            if (_db != null)
            {
                _db.Registrations.Update(registration);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<int> DeleteRegistration(int Id)
        {
            if (_db != null)
            {
                var data = await _db.Registrations.FirstOrDefaultAsync(x => x.UserId == Id);
                if (data != null)
                {
                    _db.Registrations.Remove(data);
                    return await _db.SaveChangesAsync();
                }
            }
            return 0;
        }
    }
}
