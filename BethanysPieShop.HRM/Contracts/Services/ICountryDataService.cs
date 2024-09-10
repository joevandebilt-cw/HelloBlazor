using BethanysPieShop.HRM.Shared.Domain;

namespace BethanysPieShop.HRM.Contracts.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
