using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Command.States
{
    public class DeleteStateCommand(Guid id) : IRequest<DeleteCityResponse>
    {
        public Guid Id { get; private set; } = id;
    }
}
