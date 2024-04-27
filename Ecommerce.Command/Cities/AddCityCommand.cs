using Ecommerce.Entity.Cities;
using MediatR;

namespace Ecommerce.Command.Cities
{
    public class AddCityCommand(string name, Guid stateId) : IRequest<AddCityResponse>
    {
        public string Name { get; private set; } = name;

        public Guid StateId { get; private set; } = stateId;
    }
}
