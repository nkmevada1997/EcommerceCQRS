using Ecommerce.Entity.Countries;
using MediatR;

namespace Ecommerce.Query.Countries
{
    public class GetCountryDetailQuery(Guid id) : IRequest<GetCountryDetailResponse>
    {
        public Guid Id { get; private set; } = id;
    }
}
