using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Command.Cities
{
    public class EditCityCommand(Guid id, string name, Guid stateId) : IRequest<EditCityResponse>
    {
        public Guid Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public Guid StateId { get; private set; } = stateId;
    }
}
