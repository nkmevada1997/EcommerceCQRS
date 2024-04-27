using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Query.Cities
{
    public class GetCitiesByStateIdQuery(Guid stateId) : IRequest<GetCitiesResponse>
    {
        public Guid StateId { get; private set; } = stateId;
    }
}
