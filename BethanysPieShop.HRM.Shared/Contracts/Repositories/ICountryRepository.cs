using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Shared.Contracts.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
