using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Shared.Contracts.Repositories
{
    public interface ITimeRegistrationRepository
    {

        Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId);
        Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start);
        Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
    }
}
