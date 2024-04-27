using Ecommerce.Entity.States;
using MediatR;

namespace Ecommerce.Query.States
{
    public class GetStateDetailQuery(Guid id) : IRequest<GetStateDetailResponse>
    {
        public Guid Id { get; set; } = id;
    }
}
