using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
    }
}
