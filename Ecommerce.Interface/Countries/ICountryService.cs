using Ecommerce.Entity.Countries;

namespace Ecommerce.Interface.Countries
{
    public interface ICountryService
    {
        Task<AddCountryResponse> AddCountryAsync(AddCountryRequest request);
        Task<GetCountriesResponse> GetCountriesAsync();
        Task<GetCountryDetailResponse> GetCountryDetailAsync(Guid Id);
        Task<EditCountryResponse> EditCountryAsync(Guid Id, EditCountryRequest request);
        Task<DeleteCountryResponse> DeleteCountryAsync(Guid Id);
    }
}
