using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Contracts.Services
{
    public interface ITimeRegistrationDataService
    {
        Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId);
        Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId);
        Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start);
    }
}
