using TaskMgmService.Models;

namespace TaskMgmService.Repository
{
    public interface IRegisterRepository
    {
        Task<List<Registration>> GetRegistrations();
        Task<Registration> GetRegistrationsById(int Id);

        Task<int> AddRegistration(Registration registration);

        Task<int> UpdateRegistration(Registration registration);

        Task<int> DeleteRegistration(int Id);
    }
}
