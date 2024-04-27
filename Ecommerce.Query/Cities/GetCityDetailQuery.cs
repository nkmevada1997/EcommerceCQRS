using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Query.Cities
{
    public class GetCityDetailQuery(Guid id) : IRequest<GetCityDetailResponse>
    {
        public Guid Id { get; private set; } = id;
    }
}
