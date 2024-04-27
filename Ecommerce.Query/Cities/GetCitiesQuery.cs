using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Query.Cities
{
    public class GetCitiesQuery : IRequest<GetCitiesResponse>
    {
    }
}
