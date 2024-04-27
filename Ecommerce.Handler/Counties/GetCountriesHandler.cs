using Ecommerce.Entity.Countries;
using Ecommerce.Interface.Countries;
using Ecommerce.Query.Countries;
using MediatR;

namespace Ecommerce.Handler.Counties
{
    public class GetCountriesHandler(ICountryService service) : IRequestHandler<GetCountriesQuery, GetCountriesResponse>
    {
        readonly ICountryService _service = service;

        public async Task<GetCountriesResponse> Handle(GetCountriesQuery query, CancellationToken cancellationToken)
        {
            return await _service.GetCountriesAsync();
        }
    }
}
