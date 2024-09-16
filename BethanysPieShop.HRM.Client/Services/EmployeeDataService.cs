using BethanysPieShop.HRM.Client.Pages;
using BethanysPieShop.HRM.Shared.Constants;
using BethanysPieShop.HRM.Shared.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using BethanysPieShop.HRM.Shared.Extensions;
using Blazored.LocalStorage;

namespace BethanysPieShop.HRM.Client.Services
{
    public class EmployeeDataService(HttpClient httpClient, ILocalStorageService localStorageService) : IEmployeeDataService
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
            var expiryKey = Constants.CacheKeys.EmployeeListExpiryTime;
            var entityKey = Constants.CacheKeys.EmployeeList;

            IEnumerable<Employee> results = null!;
            if (await localStorageService.ContainKeyAsync(Constants.CacheKeys.EmployeeListExpiryTime))
            {
                var expiryTime = await localStorageService.GetItemAsync<DateTime>(expiryKey);
                if (DateTime.Now < expiryTime && await localStorageService.ContainKeyAsync(expiryKey))
                {
                    return (await localStorageService.GetItemAsync<IEnumerable<Employee>>(entityKey))!;
                }
            }
            
            if (results == null)
            {
                results = (await httpClient.MakeWebRequest<IEnumerable<Employee>>(HttpMethod.Get, "/api/employee"))!;
                await localStorageService.SetItemAsync(entityKey, results);
                await localStorageService.SetItemAsync(expiryKey, DateTime.Now.AddHours(1));
            }
            return results!;
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            var expiryKey = string.Format(Constants.CacheKeys.EmployeeListExpiryTime, employeeId);
            var entityKey = string.Format(Constants.CacheKeys.Employee, employeeId);

            Employee result = null!;
            if (await localStorageService.ContainKeyAsync(expiryKey))
            {
                var expiryTime = await localStorageService.GetItemAsync<DateTime>(expiryKey);
                if (DateTime.Now < expiryTime && await localStorageService.ContainKeyAsync(entityKey))
                {
                    return (await localStorageService.GetItemAsync<Employee>(entityKey))!;
                }
            }

            if (result == null)
            {
                result = (await httpClient.MakeWebRequest<Employee>(HttpMethod.Get, $"/api/employee/{employeeId}"))!;
                await localStorageService.SetItemAsync(entityKey, result);
                await localStorageService.SetItemAsync(expiryKey, DateTime.Now.AddMinutes(1));
            }
            return result!;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await httpClient.MakeWebRequest(HttpMethod.Patch, "/api/employee", employee);
            return result!;
        }
    }
}
