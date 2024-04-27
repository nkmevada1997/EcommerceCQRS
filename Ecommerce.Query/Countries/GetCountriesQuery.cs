using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Query.Countries
{
    public class GetCountriesQuery : IRequest<GetCountriesResponse>
    {
    }
}
