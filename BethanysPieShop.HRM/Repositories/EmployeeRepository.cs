using BethanysPieShop.HRM.Data;
using BethanysPieShop.HRM.Shared.Contracts.Repositories;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.HRM.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(IDbContextFactory<AppDbContext> DbFactory)
        {
            _appDbContext = DbFactory.CreateDbContext();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            //return await Task.FromResult(_appDbContext.Employees);
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _appDbContext.Employees.SingleAsync(c => c.EmployeeId == employeeId);
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

		public async Task<Employee> AddEmployee(Employee employee)
		{
            var addedEntity = await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return addedEntity.Entity;
		}

		public async Task<Employee> UpdateEmployee(Employee employee)
		{
            var existingEmployee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.CountryId  = employee.CountryId;
                existingEmployee.MaritalStatus  = employee.MaritalStatus;
                existingEmployee.BirthDate = employee.BirthDate;
                existingEmployee.City = employee.City;
				existingEmployee.Email = employee.Email;
				existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.PhoneNumber = employee.PhoneNumber;
                existingEmployee.Smoker = employee.Smoker;
                existingEmployee.Street = employee.Street;
                existingEmployee.Zip =  employee.Zip;
                existingEmployee.JobCategoryId = employee.JobCategoryId;
                existingEmployee.Comment = employee.Comment;
                existingEmployee.ExitDate = employee.ExitDate;
                existingEmployee.JoinedDate = employee.JoinedDate;
                existingEmployee.ImageContent = employee.ImageContent;
                existingEmployee.ImageName = employee.ImageName;                

                await _appDbContext.SaveChangesAsync();

                return existingEmployee;
            }
            return null!;
		}

		public async Task DeleteEmployee(int employeeId)
		{
            var foundEmployee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) return;

            _appDbContext.Remove(foundEmployee);
            await _appDbContext.SaveChangesAsync();
		}
	}
}
