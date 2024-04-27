using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Query.States
{
    public class GetStatesByCountryIdQuery(Guid countryId) : IRequest<GetCountriesResponse>
    {
        public Guid CountryId { get; private set; } = countryId;
    }
}
