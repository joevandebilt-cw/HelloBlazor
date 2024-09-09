using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
