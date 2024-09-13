using BethanysPieShop.HRM.Shared.Contracts.Repositories;
using BethanysPieShop.HRM.Shared.Contracts.Services;
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

		public async Task<Employee> AddEmployee(Employee employee)
		{
			return await _employeeRepository.AddEmployee(employee);
		}

		public async Task DeleteEmployee(int employeeId)
		{
			await _employeeRepository.DeleteEmployee(employeeId);
		}

		public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

		public async Task<Employee> UpdateEmployee(Employee employee)
		{
			return await _employeeRepository.UpdateEmployee(employee);
		}
	}
}
