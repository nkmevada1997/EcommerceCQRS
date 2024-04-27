using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Command.Cities
{
    public class DeleteCityCommand(Guid id) : IRequest<DeleteCityResponse>
    {
        public Guid Id { get; private set; } = id;
    }
}
