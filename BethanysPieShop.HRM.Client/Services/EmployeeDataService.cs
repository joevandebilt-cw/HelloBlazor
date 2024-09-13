using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using BethanysPieShop.HRM.Shared.Extensions;

namespace BethanysPieShop.HRM.Client.Services
{
    public class EmployeeDataService(HttpClient httpClient) : IEmployeeDataService
    {
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await httpClient.MakeWebRequest(HttpMethod.Post, "/api/employee", employee);
            return result!;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var result = await httpClient.MakeWebRequest<IEnumerable<Employee>>(HttpMethod.Get, "/api/employee");
            return result!;
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            var result = await httpClient.MakeWebRequest<Employee>(HttpMethod.Get, $"/api/employee/{employeeId}");
            return result!;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await httpClient.MakeWebRequest(HttpMethod.Patch, "/api/employee", employee);
            return result!;
        }
    }
}
