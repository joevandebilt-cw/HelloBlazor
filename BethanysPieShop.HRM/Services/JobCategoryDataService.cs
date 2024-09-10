using BethanysPieShop.HRM.Contracts.Repositories;
using BethanysPieShop.HRM.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Services
{
    public class JobCategoryDataService : IJobCategoryDataService
    {
        private readonly IJobCategoryRepository _jobCategoryRepository;

        public JobCategoryDataService(IJobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await _jobCategoryRepository.GetAllJobCategories();
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await _jobCategoryRepository.GetJobCategoryById(jobCategoryId);
        }
    }
}
