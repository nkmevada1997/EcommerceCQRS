using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;

namespace Ecommerce.Service
{
    public class CountryService(ICountryRepository repository) : ICountryService
    {
        readonly ICountryRepository _repository = repository;

        public async Task<AddCountryResponse> AddCountryAsync(AddCountryRequest request)
        {
            return await _repository.AddCountryAsync(request);
        }

        public async Task<GetCountriesResponse> GetCountriesAsync()
        {
            return await _repository.GetCountriesAsync();
        }

        public async Task<GetCountryDetailResponse> GetCountryDetailAsync(Guid Id)
        {
            return await _repository.GetCountryDetailAsync(Id);
        }

        public async Task<EditCountryResponse> EditCountryAsync(Guid Id, EditCountryRequest request)
        {
            return await _repository.EditCountryAsync(Id, request);
        }

        public async Task<DeleteCountryResponse> DeleteCountryAsync(Guid Id)
        {
            return await _repository.DeleteCountryAsync(Id);
        }
    }
}
