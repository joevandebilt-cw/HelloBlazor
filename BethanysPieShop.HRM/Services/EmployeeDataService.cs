using BethanysPieShop.HRM.Contracts.Repositories;
using BethanysPieShop.HRM.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeDataService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

    }
}
