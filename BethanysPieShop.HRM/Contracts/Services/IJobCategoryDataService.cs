using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Contracts.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
